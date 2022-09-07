using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCenter.Models;
using ShoppingCenter.Data;

namespace ShoppingCenter.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext context)
        {
            this._db = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> list = this._db.Categories;
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                this._db.Categories.Add(category);
                this._db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var category = _db.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                this._db.Categories.Update(category);
                this._db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var category = _db.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult DeletePost(int? CategoryId = null)
        {
            if (CategoryId == null || CategoryId == 0)
            {
                return NotFound();
            }
            var category = _db.Categories.Find(CategoryId);
            if (category == null)
            {
                return NotFound();
            }
            this._db.Categories.Remove(category);
            this._db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
