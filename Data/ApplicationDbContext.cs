using Playlist.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Playlist.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {

        public DbSet<User> users { get; set; }


        public DbSet<Models.Music> musics { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
