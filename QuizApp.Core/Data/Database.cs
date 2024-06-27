using Microsoft.EntityFrameworkCore;
using QuizApp.Core.Data.Models;

#pragma warning disable CS8618 // Needed for EF Core
// ReSharper disable UnusedAutoPropertyAccessor.Global = Needed for EF Core

namespace QuizApp.Core.Data;

public abstract class DatabaseContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasKey(x => x.Id);
        modelBuilder.Entity<Quiz>().HasKey(x => x.Id);
    }
}

public class SqliteDbContext : DatabaseContext
{
    public const string DbName = "QuizApp.db";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbName}");
    }
}

// public class MySqlDbContext : DatabaseContext
// {
//     private static readonly string MySqlConnectionString = $"server={MediaTypeNames.Application.SqlCredentials.Host},{MediaTypeNames.Application.SqlCredentials.Port};" +
//                                                             $"database={MediaTypeNames.Application.SqlCredentials.Database};" +
//                                                             $"user={MediaTypeNames.Application.SqlCredentials.Username};" +
//                                                             $"password={MediaTypeNames.Application.SqlCredentials.Password};";
//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
// // #if DEBUG
// //         _mySqlConnectionString = "Server=localhost;Database=SimpleSchoolInfoSystem;User ID=test;Password=password;";
// // #endif
//         optionsBuilder.UseMySql(MySqlConnectionString, ServerVersion.AutoDetect(MySqlConnectionString));
//     }
// }