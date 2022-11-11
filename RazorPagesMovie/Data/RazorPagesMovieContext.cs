﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : IdentityDbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; } = default!;
        //public DbSet<RazorPagesMovie.ViewModels.RegisterViewModel> RegisterViewModel { get; set; } = default!;


    }
}
