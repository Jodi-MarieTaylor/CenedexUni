using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CenedexUniversity;
using CenedexUniversity.Model;

namespace CenedexUniversity.Controllers
{
    public class CourseLecturersController : Controller
    {
        private readonly cenedexUniversityDbContext _context;

        public CourseLecturersController(cenedexUniversityDbContext context)
        {
            _context = context;
        }

        // GET: CourseLecturers
        public async Task<IActionResult> Index()
        {
            var cenedexUniversityDbContext = _context.CourseLecturer.Include(c => c.Course).Include(c => c.Lecturer);
            return View(await cenedexUniversityDbContext.ToListAsync());
        }

        // GET: CourseLecturers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseLecturer = await _context.CourseLecturer
                .Include(c => c.Course)
                .Include(c => c.Lecturer)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (courseLecturer == null)
            {
                return NotFound();
            }

            return View(courseLecturer);
        }

        // GET: CourseLecturers/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Name");
            ViewData["LecturerId"] = new SelectList(_context.Lecturer, "Id", "Name");
            return View();
        }

        // POST: CourseLecturers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseId,LecturerId")] CourseLecturer courseLecturer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseLecturer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Name", courseLecturer.CourseId);
            ViewData["LecturerId"] = new SelectList(_context.Lecturer, "Id", "Name", courseLecturer.LecturerId);
            return View(courseLecturer);
        }

        // GET: CourseLecturers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseLecturer = await _context.CourseLecturer.FindAsync(id);
            if (courseLecturer == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Name", courseLecturer.CourseId);
            ViewData["LecturerId"] = new SelectList(_context.Lecturer, "Id", "Name", courseLecturer.LecturerId);
            return View(courseLecturer);
        }

        // POST: CourseLecturers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseId,LecturerId")] CourseLecturer courseLecturer)
        {
            if (id != courseLecturer.CourseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseLecturer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseLecturerExists(courseLecturer.CourseId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Name", courseLecturer.CourseId);
            ViewData["LecturerId"] = new SelectList(_context.Lecturer, "Id", "Name", courseLecturer.LecturerId);
            return View(courseLecturer);
        }

        // GET: CourseLecturers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseLecturer = await _context.CourseLecturer
                .Include(c => c.Course)
                .Include(c => c.Lecturer)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (courseLecturer == null)
            {
                return NotFound();
            }

            return View(courseLecturer);
        }

        // POST: CourseLecturers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseLecturer = await _context.CourseLecturer.FindAsync(id);
            _context.CourseLecturer.Remove(courseLecturer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseLecturerExists(int id)
        {
            return _context.CourseLecturer.Any(e => e.CourseId == id);
        }

        //Post: Search
        [HttpPost]
        public JsonResult Search(string input)
        {
            try
            {
                var list = _context.CourseLecturer.Where(s => s.Lecturer.Name.StartsWith(input) || input == null).ToList();
                return Json(new { status = 200, values = list });
            }
            catch (Exception e)
            {
                return Json(new { status = 500, message = e.Message });
            }


        }

    }
}
