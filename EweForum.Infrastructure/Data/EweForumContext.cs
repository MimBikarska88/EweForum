﻿using EweForum.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EweForum.Data;

public class EweForumContext : IdentityDbContext<IdentityUser>
{
    public EweForumContext(DbContextOptions<EweForumContext> options)
        : base(options)
    {
    }

    protected override async void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        

        builder.Entity<Post>().HasOne(entry => entry.Topic).WithMany(entry => entry.Posts).OnDelete(DeleteBehavior.Restrict);
        
        builder.Entity<ForumUserAttachment>().HasKey(entry => new { entry.FileAttachmentId, entry.ForumUserId });
        builder.Entity<ForumUserAttachment>().HasOne(entry  => entry.ForumUser).WithMany(entry => entry.ForumUsersFilesAttachments).OnDelete(DeleteBehavior.Restrict);
        builder.Entity<ForumUserAttachment>().HasOne(entry => entry.FileAttachment).WithMany(entry => entry.ForumUsersFilesAttachments).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<JoinedTopic>().HasKey(entry => new { entry.TopicId, entry.ForumUserId });
        builder.Entity<JoinedTopic>().HasOne(entry => entry.Topic).WithMany(entry => entry.JoinedTopics).OnDelete(DeleteBehavior.Restrict);
        builder.Entity<JoinedTopic>().HasOne(entry => entry.ForumUser).WithMany(entry => entry.JoinedTopics).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<PostAttachment>().HasKey(entry => new { entry.PostId, entry.FileAttachmentId });
        builder.Entity<PostAttachment>().HasOne(entry => entry.Post).WithMany(entry => entry.PostsAttachments).OnDelete(DeleteBehavior.Restrict);
        builder.Entity<PostAttachment>().HasOne(entry => entry.FileAttachment).WithMany(entry => entry.PostsAttachments);
        
        builder.Entity<PostReply>().HasOne(entry => entry.Post)
            .WithMany(entry => entry.PostsReplies)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<ReplyClosure>()
            .HasOne(entry => entry.Parent)
            .WithMany(entry => entry.Children)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<ReplyClosure>()
            .HasOne(entry => entry.Child)
            .WithMany(entry => entry.Parents)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.Entity<Like>().HasKey(entry => new { entry.PostId, entry.UserId });
        builder.Entity<Like>().HasOne(entry => entry.Post).WithMany(entry => entry.Likes).OnDelete(DeleteBehavior.Restrict);
        builder.Entity<Like>().HasOne(entry => entry.User).WithMany(entry => entry.Likes).OnDelete(DeleteBehavior.Restrict);
        

        builder.SeedCountries();
        builder.SeedTopics();
        builder.SeedUsers();
        builder.SeedJoinedTopics();
        builder.SeedPosts();
    }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<ForumUser>ForumUsers { get; set; }
    public DbSet<Topic> Topics { get; set; }

    public DbSet<Like>Likes { get; set; }
    public DbSet<PostAttachment> PostsAttachments { get; set; }

    public DbSet<FileAttachment>FilesAttachments { get; set; }  

    public DbSet<ForumUserAttachment> ForumUsersAttachments { get; set; }

    public DbSet<PostReply>PostsReplies {  get; set; }  

    public DbSet<ReplyClosure> RepliesClosures { get; set;}

    public DbSet<JoinedTopic> JoinedTopic { get; set; }

    public string SuccessMessage { get; set; } = string.Empty;

    public string ErrorMessage { get; set; } = string.Empty;
}
