using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Adventure", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Animation", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Biography", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Comedy", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Crime", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Documentary", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Drama", DisplayOrder = 8 },
                new Category { Id = 9, Name = "Family", DisplayOrder = 9 },
                new Category { Id = 10, Name = "Fantasy", DisplayOrder = 10 },
                new Category { Id = 11, Name = "Film-Noir", DisplayOrder = 11 },
                new Category { Id = 12, Name = "History", DisplayOrder = 12 },
                new Category { Id = 13, Name = "Horror", DisplayOrder = 13 },
                new Category { Id = 14, Name = "Music", DisplayOrder = 14 },
                new Category { Id = 15, Name = "Musical", DisplayOrder = 15 },
                new Category { Id = 16, Name = "Mystery", DisplayOrder = 16 },
                new Category { Id = 17, Name = "Romance", DisplayOrder = 17 },
                new Category { Id = 18, Name = "Sci-Fi", DisplayOrder = 18 },
                new Category { Id = 19, Name = "Short", DisplayOrder = 19 },
                new Category { Id = 20, Name = "Sport", DisplayOrder = 20 },
                new Category { Id = 21, Name = "Superhero", DisplayOrder = 21 },
                new Category { Id = 22, Name = "Thriller", DisplayOrder = 22 },
                new Category { Id = 23, Name = "War", DisplayOrder = 23 },
                new Category { Id = 24, Name = "Western", DisplayOrder = 24 },
                new Category { Id = 25, Name = "Disaster", DisplayOrder = 25 },
                new Category { Id = 26, Name = "Epic", DisplayOrder = 26 },
                new Category { Id = 27, Name = "Survival", DisplayOrder = 27 },
                new Category { Id = 28, Name = "Psychological", DisplayOrder = 28 },
                new Category { Id = 29, Name = "Paranormal", DisplayOrder = 29 },
                new Category { Id = 30, Name = "Heist", DisplayOrder = 30 },
                new Category { Id = 31, Name = "Spy", DisplayOrder = 31 },
                new Category { Id = 32, Name = "Zombie", DisplayOrder = 32 },
                new Category { Id = 33, Name = "Christmas", DisplayOrder = 33 },
                new Category { Id = 34, Name = "Martial Arts", DisplayOrder = 34 },
                new Category { Id = 35, Name = "Time Travel", DisplayOrder = 35 },
                new Category { Id = 36, Name = "Space", DisplayOrder = 36 },
                new Category { Id = 37, Name = "Alien", DisplayOrder = 37 },
                new Category { Id = 38, Name = "Spy Thriller", DisplayOrder = 38 },
                new Category { Id = 39, Name = "Legal", DisplayOrder = 39 },
                new Category { Id = 40, Name = "Medical", DisplayOrder = 40 },
                new Category { Id = 41, Name = "Teen", DisplayOrder = 41 },
                new Category { Id = 42, Name = "Political", DisplayOrder = 42 },
                new Category { Id = 43, Name = "Road Movie", DisplayOrder = 43 },
                new Category { Id = 44, Name = "Coming-of-Age", DisplayOrder = 44 },
                new Category { Id = 45, Name = "Satire", DisplayOrder = 45 },
                new Category { Id = 46, Name = "Detective", DisplayOrder = 46 },
                new Category { Id = 47, Name = "Mockumentary", DisplayOrder = 47 },
                new Category { Id = 48, Name = "Found Footage", DisplayOrder = 48 },
                new Category { Id = 49, Name = "Game Show", DisplayOrder = 49 },
                new Category { Id = 50, Name = "Tragedy", DisplayOrder = 50 }
            );
        }
    }
}
