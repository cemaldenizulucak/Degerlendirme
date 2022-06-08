using Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    public class NoteController : Controller
    {
        private readonly ILogger<NoteController> _logger;
        private readonly NoteContext _context;

        public NoteController(ILogger<NoteController> logger, NoteContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {

            var list = _context.Notes.ToList();

            return View(list);

        }
        public async Task<IActionResult> DeleteNote(int? id)
        {
            Note note = await _context.Notes.FindAsync(id);
            _context.Remove(note);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateNote(int Id)
        {
            var note = await _context.Notes.FindAsync(Id);
            return Json(note);
        }
        public IActionResult Publish(int Id)
        {
            var blog = _context.Notes.Find(Id);
            blog.IsPublish = true;
            _context.Update(blog);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Note()
        {
            ViewBag.Categories = _context.Categories.Select(w =>
            new SelectListItem
            {
                Text = w.Name,
                Value = w.Id.ToString()
            }
            ).ToList();

            ViewBag.Tags = _context.Tags.Select(w =>
            new SelectListItem
            {
                Text = w.Name,
                Value = w.Id.ToString()
            }
            ).ToList();
            return View();

        }
        public async Task<IActionResult> SaveNote(Note note)
        {
            if (note != null)
            {
                
                note.AuthorId = (int)HttpContext.Session.GetInt32("id");
                await _context.AddAsync(note);
                await _context.SaveChangesAsync();
                return Json(true);

            }

            return Json(false);

        }

    }
}
