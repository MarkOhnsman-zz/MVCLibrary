using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCLibrary.Models;

namespace MVCLibrary.Controllers
{
  public class LibraryController : Controller
  {

    private LibraryContext _db;

    public LibraryController(LibraryContext db)
    {
      _db = db;
    }

    public IActionResult Index()
    {
      var libraries = _db.Libraries.ToList();
      return View(libraries);
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Library lib)
    {
      if(ModelState.IsValid){
        _db.Libraries.Add(lib);
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    [HttpGet("/Library/{id}/details")]
    public IActionResult Details(int id){
      var library = _db.Libraries.Include(lib => lib.Books).FirstOrDefault(lib => lib.Id == id);
      if(library == null){
        return NotFound("Sorry no library at that id");
      }
      return View(library);
    }

  }


}
