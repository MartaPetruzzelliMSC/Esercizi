using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Test0001.Models
{
    public class CodeFirstDbContext : DbContext
    {
        public CodeFirstDbContext(DbContextOptions<CodeFirstDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Category>()
                .HasOne(u => u.Operator)
                .WithMany()
                .HasForeignKey(p => p.OperatorId)
                .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<Movie>()
                .HasOne(u => u.Operator)
                .WithMany()
                .HasForeignKey(p => p.OperatorId)
                .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<Director>()
                .HasOne(u => u.Operator)
                .WithMany()
                .HasForeignKey(p => p.OperatorId)
                .OnDelete(DeleteBehavior.Restrict);
            
            //modelBuilder.Entity<Comment>()
            //    .HasOne(u => u.User)
            //    .WithMany()
            //    .HasForeignKey(p => p.UserId)
            //    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
               .HasIndex(u => u.Email)
               .IsUnique();

            modelBuilder.Entity<Operator>().HasData(
               new Operator { Id = 1, OperatorName = "admin"}
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "marta", Email = "marta@example.com"},
                new User { Id = 2, Username = "spazzabilly", Email = "claudio@example.com" },
                new User { Id = 3, Username = "GiulioAbridged", Email = "abriged@example.com" },
                new User { Id = 4, Username = "jackomino", Email = "jack@example.com" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Fantasy" },
                new Category { Id = 2, Name = "Thriller" },
                new Category { Id = 3, Name = "Comedy" }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Harry Potter and The Prisoner of Azkaban", CategoryId = 1},
                new Movie { Id = 2, Title = "Fractured", CategoryId = 2 },
                new Movie { Id = 3, Title = "Tre uomini e una gamba", CategoryId = 3 },
                new Movie { Id = 4, Title = "The Fellowship of the Ring", CategoryId = 1 },
                new Movie { Id = 5, Title = "Ice age", CategoryId = 3 },
                new Movie { Id = 6, Title = "Cloudy with a chance of meatballs", CategoryId = 3 },
                new Movie { Id = 7, Title = "The LEGO Movie", CategoryId = 3 }
            );

            modelBuilder.Entity<Director>().HasData(
                new Director { Id = 1, Name = "Phil", Surname = "Lord" },
                new Director { Id = 2, Name = "Chris", Surname = "Miller" },
                new Director { Id = 3, Name = "Alfonso", Surname = "Cuaròn" },
                new Director { Id = 4, Name = "Peter", Surname = "Jackson" },
                new Director { Id = 5, Name = "Brad", Surname = "Anderson" },
                new Director { Id = 6, Name = "Massimo", Surname = "Venier" },
                new Director { Id = 7, Name = "Chris", Surname = "Wedge" },
                new Director { Id = 8, Name = "Carlos", Surname = "Saldanha" }
                );

            modelBuilder.Entity<Director>()
                .HasMany(s => s.Movies)
                .WithMany(c => c.Directors)
                .UsingEntity("DirectorsMovies",
                    r => r.HasOne(typeof(Movie)).WithMany().HasForeignKey("MoviesId").HasPrincipalKey(nameof(Movie.Id)).OnDelete(DeleteBehavior.Restrict),
                    l => l.HasOne(typeof(Director)).WithMany().HasForeignKey("DirectorsId").HasPrincipalKey(nameof(Director.Id)).OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity("DirectorsMovies").HasData(
                 new { DirectorsId = 1, MoviesId = 6 },
                 new { DirectorsId = 2, MoviesId = 6 },
                 new { DirectorsId = 1, MoviesId = 7 },
                 new { DirectorsId = 2, MoviesId = 7 },
                 new { DirectorsId = 3, MoviesId = 1 },
                 new { DirectorsId = 5, MoviesId = 2 },
                 new { DirectorsId = 6, MoviesId = 3 },
                 new { DirectorsId = 4, MoviesId = 4 },
                 new { DirectorsId = 7, MoviesId = 5 },
                 new { DirectorsId = 8, MoviesId = 5 }
                );

            //modelBuilder.Entity<Comment>()
            //    .HasOne(typeof(Movie)).WithMany().HasForeignKey("MoviesId").HasPrincipalKey(nameof(Movie.Id));

            //modelBuilder.Entity<Comment>()
            //    .HasOne(typeof(User)).WithMany().HasForeignKey("UsersId").HasPrincipalKey(nameof(User.Id));

            //modelBuilder.Entity<Comment>()
            //    .HasKey(c => c.Id);

            modelBuilder.Entity<Movie>()
                .HasMany(s => s.Users)
                .WithMany(c => c.Movies)
                .UsingEntity("Bookmarks");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
            warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
    }
}
