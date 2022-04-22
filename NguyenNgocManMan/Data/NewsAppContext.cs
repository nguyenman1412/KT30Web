using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenNgocManMan.Models;

    public class NewsAppContext : DbContext
    {
        public NewsAppContext (DbContextOptions<NewsAppContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenNgocManMan.Models.Category> Category { get; set; }

        public DbSet<NguyenNgocManMan.Models.Comment> Comment { get; set; }

        public DbSet<NguyenNgocManMan.Models.News> News { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Comment>().ToTable("Comment");
            modelBuilder.Entity<News>().ToTable("News");
        }
    }
