using Microsoft.AspNetCore.Mvc;
using NguyenVanToanBTH2.Data;
using NguyenVanToanBTH2.Models;
using Microsoft.EntityFrameworkCore;


namespace NguyenVanToanBTH2.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Students.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student std)
        {
            if (ModelState.IsValid)
            {
                _context.Add(std);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(std);
        }



        //public async Task<IActionResult> Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        //return NotFound();
        //        return View("NotFound");
        //    }

        //    var student = await _context.Students.FindAsync();
        //    if (student == null)
        //    {
        //        //return NotFound();
        //        return View("NotFound");

        //    }
        //    return View(student);

        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(string id, [Bind("StudentID,StudentName")] Student std)
        //{
        //    if (id != std.StudentID)
        //    {
        //        //return NotFound();
        //        return View("NotFound");
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(std);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!StudentExists(std.StudentID))
        //            {
        //                //return NotFound();
        //                return View("NotFound");
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(std);
        //}


        ////GET: Product/Delete/5

        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        //return NotFound();
        //        return View("NotFound");
        //    }
        //    var std = await _context.Students
        //        .FirstOrDefaultAsync(m => m.StudentID == id);
        //    if (std == null)
        //    {
        //        //return NotFound();
        //        return View("NotFound");
        //    }
        //       return View(std);
        //    }


        ////POST: Product/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]

        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var std = await _context.Students.FindAsync(id);
        //    _context.Students.Remove(std);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

    }
    }
