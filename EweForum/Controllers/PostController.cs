using EweForum.Data;
using EweForum.Infrastructure.Data.Models;
using EweForum.Models;
using EweForum.Utilites.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Text;

namespace EweForum.Controllers
{
    public class PostController : BaseController
    {
        private readonly EweForumContext _context;

        public PostController(EweForumContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Create(int topicId)
        {
            var postModel = new PostViewModel();
            postModel.TopicId = topicId;
            postModel.Username = User.Identity.Name;
               
            return View(postModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create(PostViewModel model)
        {
            if(!Enum.IsDefined(typeof(PostType), model.PostType))
            {
                return BadRequest("There is no such type");
            }
            PostType type = (PostType) Enum.Parse(typeof(PostType), model.PostType.ToString());
            var stringBuilder = new StringBuilder();
            
            var post = new Post();
            switch (type)
            {
                case PostType.Text:
                    {
                        if(model.Title == "" || model.Content == "")
                        {
                            stringBuilder.AppendLine("For text post you must provide both Title and Content");
                        }
                        if(model.Title.Length < 10)
                        {
                            stringBuilder.AppendLine("Title must be at least 10 symbols");
                        }
                        if(model.Content.Length < 50)
                        {
                            stringBuilder.AppendLine("Post content must be at least 50 symbols");
                        }
                        if(stringBuilder.Length > 0)
                        {
							TempData["Error"] = stringBuilder.ToString();
							return View(model);
                        }
                        post.TopicId = model.TopicId;
                        post.Title = model.Title;
                        post.Content = model.Content;
                        post.PostType = type;
                        post.ForumUser = await _context.ForumUsers
                            .OfType<ForumUser>()
                            .Where(u => u.Id == GetUserId())
                            .FirstOrDefaultAsync();

                    }
                    break;
                
                case PostType.Event:
                    {
                        

                        if (model.Start == null || model.Start == "" 
                            ||  model.EventDescription== null 
                            || model.EventDescription.Trim() == ""
                            || model.EventTitle == null || model.EventTitle.Trim()=="")
                        {
                            stringBuilder.AppendLine("You must provide Title, Start date,(optional) End date and Description for your event!");
                        }
                        if(model.Start!= "" && DateTime.TryParse(model.Start, out var start))
                        {
							post.Start = start;
						}
                        else
                        {
							stringBuilder.AppendLine("Start date is not in correct format");
						}
                        if(model.End!=null && model.End != "")
                        {
                            if (model.End != null && model.End != "" && DateTime.TryParse(model.End, out var end))
                            {
                                post.End = end;
                            }
                            else
                            {
                                stringBuilder.AppendLine("End date is not in correct format");
                            }
                        }
                       
                        if(stringBuilder.Length > 0)
                        {
                            TempData["Error"] = stringBuilder.ToString();
                            return View(model);
                        }
                        post.TopicId = model.TopicId;
                        post.EventDescription = model.EventDescription.Trim() ;
                        post.PostType = type;
						post.ForumUser = await _context.ForumUsers
						   .OfType<ForumUser>()
						   .Where(u => u.Id == GetUserId())
						   .FirstOrDefaultAsync();
					}
                    break;

                case PostType.Media:
                {
                        if(model.VideoTitle==null || model.VideoTitle.Trim() == "")
                        {
                            stringBuilder.AppendLine("Title for the video is missing");
                        }
                        if(model.VideoUrl == null || model.VideoUrl.Trim() == "")
                        {
                            stringBuilder.AppendLine("URL is missing.");
                        }
                        if (model.VideoDescription == null || model.VideoDescription.Trim() == "")
                        {
							stringBuilder.AppendLine("Description is missing.");
						}
                        if(stringBuilder.Length > 0)
                        {
							TempData["Error"] = stringBuilder.ToString();
                            return View(model);
						}
                        post.TopicId = model.TopicId;
                        post.VideoDescription = model.VideoDescription.Trim();
                        post.VideoUrl = model.VideoUrl;
                        post.PostType = type;
						post.ForumUser = await _context.ForumUsers
						   .OfType<ForumUser>()
						   .Where(u => u.Id == GetUserId())
						   .FirstOrDefaultAsync();
					}
                    break;
            }
            post.CreatedOn = DateTime.Now;
            post.ModifiedOn = DateTime.Now;
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            return RedirectToAction("View", "Topic", new { topicId = model.TopicId });
        }

        [HttpGet]
        public async Task<IActionResult> View([FromQuery] int postId)
        {
            var post = await _context.Posts
                .Include(p => p.Likes)
                .Include(p => p.PostsReplies)
                .Where(p => p.Id == postId)
                .Select(p =>
                    new {
                         p.Likes, 
                         p.Id,
                         p.ForumUserId,
                         p.PostType,
                         p.CreatedOn,
                         p.ModifiedOn,
                         p.Start,
                         p.End,
                         p.EventTitle,
                         p.EventDescription,
                         p.VideoTitle,
                         p.Title,
                         p.Content,
                         p.VideoDescription,
                         Username = p.ForumUser.UserName,
                         p.VideoUrl,
                        })
                .FirstOrDefaultAsync();
            if(post == null)
            {
                return NotFound();
            }

            var replies = await _context.RepliesClosures
                .Include(rp => rp.Parent)
                .ThenInclude(r => r.ForumUser)
                .Where(rp => rp.Depth == 0)
                .Select(rp => new ReplyViewModel
                {
                    Content = rp.Parent.Content,
                    CreatedOn = rp.Parent.CreatedOn.ToLongDateString(),
                    Id = rp.ParentId,
                    PostId = postId, 
                    Username = rp.Parent.ForumUser.UserName,
                    Depth = rp.Depth,

                }).ToListAsync();

            var postViewModel = new ViewPostModelDetails
            {
                Id = postId,
                LikesCount = post.Likes.Count(),
                HasLiked = post.Likes.Any(l => l.UserId == GetUserId()),
                PostType = (int)post.PostType,
                Content = post.Content,
                CreatedOn = post.CreatedOn.ToLongDateString(),
                IsNew = post.CreatedOn.Month == DateTime.Today.Month && post.CreatedOn.Year == DateTime.Today.Year,
                Username = post.Username,
                Title = post.Title,
                EventTitle = post.EventTitle,
                EventDescription = post.EventDescription,
                Start = post.Start.ToShortDateString(),
                End = post.End.Year == 1 ? "" : post.End.ToShortDateString(),
                VideoUrl = post.VideoUrl,
                VideoTitle = post.VideoTitle,
                VideoDescription = post.VideoDescription,
                Replies = replies,
                ShowDetailsButton = false
			};
            ViewBag.ShowDetailsButtonVisible = false;
            return View(postViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> AddReplyToPost(ReplyViewModel replyViewModel)
        {
            var post = await _context.Posts.FindAsync(replyViewModel.PostId);
            if (post == null)
            {
                return BadRequest();
            }
            var postReply = new PostReply
            {
                CreatedOn = DateTime.Now,
                PostId = replyViewModel.PostId,
                UserId = GetUserId(),
                Content = replyViewModel.Content,
                IsDeleted = false
            };


            await _context.RepliesClosures.AddAsync(new ReplyClosure
            {
                Parent = postReply,
                Child = postReply,
                Depth = 0
            }) ;
         await _context.SaveChangesAsync();
            ModelState.Clear();
            return RedirectToAction("View", "Post", new { postId = replyViewModel.PostId });
        }

        [HttpPost]

        public async Task<IActionResult> AddReplyToComment(ReplyToCommentViewModel replyViewModel)
        {
            PostReply parent = await _context.PostsReplies.FindAsync(replyViewModel.ParentId);
            if (parent == null)
            {
                return BadRequest();
            }

            PostReply postReply = new PostReply
            {
                CreatedOn = DateTime.Now,
                PostId = replyViewModel.PostId,
                UserId = GetUserId(),
                Content = replyViewModel.Content,
                IsDeleted = false
            };
            postReply.Parents.Add(new ReplyClosure
            {
                Parent = parent,
                ParentId = replyViewModel.ParentId,
                Depth = replyViewModel.Depth,
            });
            await _context.PostsReplies.AddAsync(postReply);
            await _context.SaveChangesAsync();
            return RedirectToAction("View", "Post", new
            {
                postId = replyViewModel.PostId
            });
        }

        [HttpGet]
        public async Task<IActionResult> ViewReply(int postId, int parentId, int depth)
        {
            ModelState.Clear();
            var commentWithReplies = await _context.PostsReplies
                .Include(r => r.Children)
                .ThenInclude(c => c.Child)
                .ThenInclude(c => c.ForumUser)
                .Where(p => p.Id == parentId)
                .Select(p => new
                {
                    PostId = p.PostId,
                    Id = p.Id,
                    Children = p.Children
                    .Where(c => c.Depth==depth)
                    .Select(c => new
                    {
                        CreatedOn = c.Child.CreatedOn,
                        Id = c.Child.Id,
                        Content = c.Child.Content,
                        ParentId = parentId,
                        Username = c.Child.ForumUser.UserName,

                    })
                })
                .FirstOrDefaultAsync();




            var replies = commentWithReplies.Children
                  .Select(c => new ReplyViewModel
                  {
                      CreatedOn = c.CreatedOn.ToLongDateString(),
                      Username = c.Username,
                      Id = c.Id,
                      Content = c.Content,
                      PostId = commentWithReplies.PostId,
                      Depth = depth,
                    


                  }).ToList();



            return View(replies);
        }
    }
}
