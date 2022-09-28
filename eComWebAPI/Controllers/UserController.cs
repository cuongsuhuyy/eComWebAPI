using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eComWebAPI.Data;
using eComWebAPI.ViewModels.User;

namespace eComWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly eComWebAPIContext _context;

        public UserController(eComWebAPIContext context)
        {
            _context = context;
        }

        // GET: User
        [HttpGet("[action]")]
        public async Task<UserModel> GetUser()
        {
            var user = new UserModel();
            foreach (var i in _context.UserModel)
            {
                user = i;
            }
            //return View(await _context.UserModel.ToListAsync());
            return user;
        }

        // GET: User/Details/5
        //[HttpGet]
        //public async Task<IActionResult> Details(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var userModel = await _context.UserModel
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (userModel == null)
        //    {
        //        return NotFound();
        //    }

        //    //return View(userModel);
        //    return null;
        //}

        // GET: User/Create
        //[HttpGet]
        //public IActionResult Create()
        //{
        //    //return View();
        //    return null;
        //}

        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Username,Email,Password")] UserModel userModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        userModel.Id = Guid.NewGuid();
        //        _context.Add(userModel);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return null;
        //    //return View(userModel);
        //}

        // GET: User/Edit/5
        //[HttpGet]
        //public async Task<IActionResult> Edit(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var userModel = await _context.UserModel.FindAsync(id);
        //    if (userModel == null)
        //    {
        //        return NotFound();
        //    }
        //    //return View(userModel);
        //    return null;
        //}

        // POST: User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("Id,Username,Email,Password")] UserModel userModel)
        //{
        //    if (id != userModel.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(userModel);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!UserModelExists(userModel.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    //return View(userModel);
        //    return null;
        //}

        // GET: User/Delete/5
        //[HttpGet]
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var userModel = await _context.UserModel
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (userModel == null)
        //    {
        //        return NotFound();
        //    }

        //    //return View(userModel);
        //    return null;
        //}

        // POST: User/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var userModel = await _context.UserModel.FindAsync(id);
        //    _context.UserModel.Remove(userModel);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool UserModelExists(Guid id)
        //{
        //    return _context.UserModel.Any(e => e.Id == id);
        //}
    }
}
