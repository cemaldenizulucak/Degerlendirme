using Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NoteContext _context;
        public HomeController(ILogger<HomeController> logger,NoteContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Login(string Email, string Password)
        {
            var author = _context.Authors.FirstOrDefault(x => x.Email == Email && x.Password == Password);
            if (author == null)
            {
                return RedirectToAction(nameof(Index));
            }
            HttpContext.Session.SetInt32("id", author.Id);
            return RedirectToAction(nameof(Author));
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Category()
        {
            List<Category> List = _context.Categories.ToList();
            return View(List);
        }
        public async Task<IActionResult> AddCategory(Category category)
        {
            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Category));
        }
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            Category category = await _context.Categories.FindAsync(id);
            _context.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Category));
        }
        public async Task<IActionResult> CategoryUpdate(int Id)
        {
            var category = await _context.Categories.FindAsync(Id);
            return Json(category);
        }
        public IActionResult Author()
        {
            List<Author> List = _context.Authors.ToList();
            return View(List);
        }
        public async Task<IActionResult> AddAuthor(Author author)
        {
            await _context.AddAsync(author);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Author));
        }
        public async Task<IActionResult> DeleteAuthor(int? id)
        {
            Author author = await _context.Authors.FindAsync(id);
            _context.Remove(author);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Author));
        }
        public async Task<IActionResult> AuthorUpdate(int Id)
        {
            var author = await _context.Authors.FindAsync(Id);
            return Json(author);
        }
        public IActionResult Tag()
        {
            List<Tag> listag = _context.Tags.ToList();
            return View(listag);
        }
        public async Task<IActionResult> AddTag(Tag tag)
        {
            await _context.AddAsync(tag);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Tag));
        }
        public async Task<IActionResult> DeleteTag(int? id)
        {
            Tag tag = await _context.Tags.FindAsync(id);
            _context.Remove(tag);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Tag));
        }
        public async Task<IActionResult> TagUpdate(int Id)
        {
            var tag = await _context.Tags.FindAsync(Id);
            return Json(tag);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
