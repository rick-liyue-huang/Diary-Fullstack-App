using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diary_App.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Diary_App.Web.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    // Add a DbSet for DiaryEntry for creating the table in the database
    public DbSet<DiaryEntry> DiaryEntries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<DiaryEntry>().HasData(
        new DiaryEntry
        {
          Id = 1,
          Title = "Went to the beach",
          Content = "Today I went to the beach and had a great time",
          Created = new DateTime(2024, 3, 12)
        },
        new DiaryEntry
        {
          Id = 2,
          Title = "Went to the park",
          Content = "Today I went to the park and had a great time",
          Created = new DateTime(2024, 10, 3)
        },
        new DiaryEntry
        {
          Id = 3,
          Title = "Went to the movies",
          Content = "Today I went to the movies and had a great time",
          Created = new DateTime(2024, 12, 2)
        }
      );
    }
  }
}