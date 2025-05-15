using System;
using System.Collections.Generic;
using System.Text;
using HocLichSuDiaLy.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HocLichSuDiaLy.Data
{ 
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }
        public DbSet<OrderContentDetail> OrderContentDetails { get; set; }
        public DbSet<OrderContent> OrderContents { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region SachNhaXuatBan
            //modelBuilder.Entity<ContentPublisher>()
            //    .HasKey(x => new { x.ContentID, x.PublisherID });
            //modelBuilder.Entity<ContentPublisher>()
            //    .HasOne(x => x.Content)
            //    .WithMany(x => x.ContentPublishers)
            //    .HasForeignKey(x => x.ContentID);
            //modelBuilder.Entity<ContentPublisher>()
            //    .HasOne(x => x.Publisher)
            //    .WithMany(x => x.ContentPublishers)
            //    .HasForeignKey(x => x.PublisherID);
            #endregion
            #region OrderContentDetail
            modelBuilder.Entity<OrderContentDetail>()
                .HasKey(x => new { x.OrderContentID, x.ContentID });
            modelBuilder.Entity<OrderContentDetail>()
                .HasOne(x => x.Content)
                .WithMany(x => x.OrderContentDetails)
                .HasForeignKey(x => x.ContentID);
            modelBuilder.Entity<OrderContentDetail>()
                .HasOne(x => x.OrderContent)
                .WithMany(x => x.OrderContentDetails)
                .HasForeignKey(x => x.OrderContentID);
            #endregion
            modelBuilder.Entity<Author>()
                .HasKey(x => x.ID);
            modelBuilder.Entity<Content>()
                .HasOne(x => x.Author)
                .WithMany(x => x.Contents);
            modelBuilder.Entity<Category>()
                .HasKey(x => x.ID);
            modelBuilder.Entity<Content>()
                .HasOne(x => x.Category)
                .WithMany(x => x.Contents);
            modelBuilder.Entity<OrderContent>()
                .HasKey(x => x.OrderID);
            modelBuilder.Entity<Content>()
                .HasMany(x => x.OrderContentDetails)
                .WithOne(x => x.Content);
            modelBuilder.Entity<OrderContent>()
                .HasMany(x => x.OrderContentDetails)
                .WithOne(x => x.OrderContent);
            modelBuilder.Entity<Content>()
                .HasOne(x => x.Publisher)
                .WithMany(x => x.Contents);
        }
    }
}
