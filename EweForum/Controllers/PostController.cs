using EweForum.Data;
using EweForum.Infrastructure.Data.Models;
using EweForum.Models;
using EweForum.Utilites.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite.Query.Internal;
using SQLitePCL;
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
            
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            return RedirectToAction("View", "Topic", new { topicId = model.TopicId });
        }
    }
}
