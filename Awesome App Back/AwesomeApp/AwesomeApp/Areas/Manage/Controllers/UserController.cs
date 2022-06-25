﻿using AwesomeApp.DAL;
using AwesomeApp.Models;
using AwesomeApp.Utilies.Extension;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeApp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public UserController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(User user)
        {
            user.Image = await user.Photo.SaveFileAsync(Path.Combine(_env.WebRootPath, "assets", "image"));
            await _context.AddAsync(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            User user = _context.Users.Find(id);
            if (user == null) return NotFound();
            if (System.IO.File.Exists(Path.Combine(_env.WebRootPath, "assets", "image", user.Image)))
            {
                System.IO.File.Delete(Path.Combine(_env.WebRootPath, "assets", "image", user.Image));
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            User user = _context.Users.FirstOrDefault(c => c.Id == id);
            if (user == null) return NotFound();
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, User user)
        {
            if (ModelState.IsValid)
            {
                var s = await _context.Users.FindAsync(user.Id);
                s.FullName = user.FullName;
                s.Comment = user.Comment;
                s.Profession = user.Profession;
                if (user.Photo != null)
                {
                    if (user.Image != null)
                    {
                        string filePath = Path.Combine(_env.WebRootPath, "assets", "image", user.Image);
                        System.IO.File.Delete(filePath);
                    }
                    s.Image = ProcessUploadedFile(user);
                }
                _context.Update(s);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        private string ProcessUploadedFile(User user)
        {
            string uniqueFileName = null;

            if (user.Photo != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "assets", "imgs");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + user.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    user.Photo.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}
