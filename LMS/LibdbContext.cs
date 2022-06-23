﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LMS
{
    public class LibdbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;

        public string ConnectionString { get; }

        public LibdbContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(this.ConnectionString);
        }
    }


    public class Post
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;

        public long BlogId { get; set; }
        
    }
}

