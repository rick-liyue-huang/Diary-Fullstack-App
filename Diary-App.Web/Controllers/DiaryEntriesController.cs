using Diary_App.Web.Data;
using Diary_App.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Diary_App.Web.Controllers
{
  public class DiaryEntriesController : Controller
  {

    private readonly ApplicationDbContext _context;
    public DiaryEntriesController(ApplicationDbContext context)
    {
      _context = context;
    }

    // GET: DiaryEntriesController
    public ActionResult Index()
    {

      List<DiaryEntry> diaryEntries = _context.DiaryEntries.ToList();
      return View(diaryEntries);
    }

  }
}
