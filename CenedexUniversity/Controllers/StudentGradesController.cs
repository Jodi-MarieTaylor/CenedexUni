using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CenedexUniversity;
using CenedexUniversity.Model;
using System.Data.SqlClient;
using Newtonsoft.Json.Linq;

namespace CenedexUniversity.Controllers
{
    public class StudentGradesController : Controller
    {
        private readonly cenedexUniversityDbContext _context;

        public StudentGradesController(cenedexUniversityDbContext context)
        {
            _context = context;
        }

        // GET: StudentGrades
        public async Task<IActionResult> Index()
        {
            var cenedexUniversityDbContext = _context.StudentGrades.Include(s => s.Course).Include(s => s.Student);
            return View(await cenedexUniversityDbContext.ToListAsync());
        }

        // GET: StudentGrades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentGrades = await _context.StudentGrades
                .Include(s => s.Course)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentGrades == null)
            {
                return NotFound();
            }

            return View(studentGrades);
        }

        // GET: StudentGrades/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Name");
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "FirstName");
            return View();
        }

        // POST: StudentGrades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StudentId,CourseId,FinalPercentageGrade,FinalLetterGrade")] StudentGrades studentGrades)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentGrades);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Name", studentGrades.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "FirstName", studentGrades.StudentId);
            return View(studentGrades);
        }

        // GET: StudentGrades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentGrades = await _context.StudentGrades.FindAsync(id);
            if (studentGrades == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Name", studentGrades.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "FirstName", studentGrades.StudentId);
            return View(studentGrades);
        }

        // POST: StudentGrades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StudentId,CourseId,FinalPercentageGrade,FinalLetterGrade")] StudentGrades studentGrades)
        {
            if (id != studentGrades.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentGrades);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentGradesExists(studentGrades.Id))
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
            ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Name", studentGrades.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "FirstName", studentGrades.StudentId);
            return View(studentGrades);
        }

        // GET: StudentGrades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentGrades = await _context.StudentGrades
                .Include(s => s.Course)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentGrades == null)
            {
                return NotFound();
            }

            return View(studentGrades);
        }

        // POST: StudentGrades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var current_user = "JMT";
            var studentGrades = await _context.StudentGrades.FindAsync(id);
            studentGrades.IsDeleted = true;
            studentGrades.ModifiedBy = current_user;
            studentGrades.ModifiedOn = DateTime.Now.Date;
           // _context.StudentGrades.Remove(studentGrades);
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentGradesExists(int id)
        {
            return _context.StudentGrades.Any(e => e.Id == id);
        }
        //Post: Search
        [HttpPost]
        public JsonResult Search(string input)
        {
            try
            {
                var list = _context.StudentGrades.Include(s => s.Student).Where(s => s.Student.FirstName.StartsWith(input) || s.Student.LastName.StartsWith(input) || input == null);

                
                return Json(new { status = 200, values = list });
            }
            catch (Exception e)
            {
                return Json(new { status = 500, message = e.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> Report()
        {
            //var param = new SqlParameter("@fromDate", "2019-10-02");
            //var param2 = new SqlParameter("@toDate", "2029-10-02");
            //var courses  = _context.Course.FromSql("dbo.stpGetStudentCourses @fromDate = {0}, @toDate = {1}", "2019-10-02", "2029-10-12" ).ToList();
          
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "FirstName");

            ViewBag.students = new SelectList(_context.Student, "Id", "FirstName");

            //ViewBag.courses = courses;
            return View();

        }
        public JsonResult Report(string fromdate , string todate, string id)
        {
          
            var courses = _context.Course.FromSql("dbo.stpGetStudentCourses @fromDate = {0}, @toDate = {1}, @studentid = {2}", fromdate, todate, Convert.ToInt16(id)).ToList();
            //var courses = _context.StudentGrades.FromSql("dbo.stpGetStudentCourses @fromDate = {0}, @toDate = {1}, id", "2019-10-02", "2029-10-02").ToList();
            //var courses = _context.Database.ExecuteSqlCommand("stpGetStudentCourses @p0, @p1", parameters: new[] { "2019-10-02", "2020-10-12" });

            ViewBag.courses = courses;
            return Json(new { status = 200, courses });

        }

    }
}
