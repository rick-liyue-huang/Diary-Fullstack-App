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
  }
}