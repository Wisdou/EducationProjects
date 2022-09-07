using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCenter.Models;
using ShoppingCenter.Data;
using ShoppingCenter.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCenter.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        private IWebHostEnvironment _webHostEnvironment;
        public ProductController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            this._db = context;
            this._webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> products = this._db.Products;

            foreach (var product in products)
            {
                product.Category = _db.Categories.FirstOrDefault(x => x.CategoryId == product.CategoryId);
            }

            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ProductViewModel productViewModel = new ProductViewModel()
            {
                Product = new Product(),
                Categories = _db.Categories.Select(x => new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.CategoryId.ToString()
                })
            };

            return View("Redact", productViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Redact(ProductViewModel pr)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                string webRootPath = _webHostEnvironment.WebRootPath;

                if (pr.Product.Id == 0)
                {
                    string uploadImg = webRootPath + WebConstants.ProductImagePath;
                    string fileName = Guid.NewGuid().ToString();
                    string extension = Path.GetExtension(files[0].FileName);

                    using (var fileStream = new FileStream(Path.Combine(uploadImg, fileName + extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }

                    pr.Product.Image = fileName + extension;

                    this._db.Products.Add(pr.Product);
                }
                else
                {
                    var prodFromDb = _db.Products.AsNoTracking().FirstOrDefault(x => x.Id == pr.Product.Id);

                    if (files.Count > 0)
                    {
                        string uploadImg = webRootPath + WebConstants.ProductImagePath;
                        string fileName = Guid.NewGuid().ToString();
                        string extension = Path.GetExtension(files[0].FileName);

                        var oldFile = Path.Combine(uploadImg + prodFromDb.Image);

                        if (System.IO.File.Exists(oldFile))
                        {
                            System.IO.File.Delete(oldFile);
                        }

                        using (var fileStream = new FileStream(Path.Combine(uploadImg, fileName + extension), FileMode.Create))
                        {
                            files[0].CopyTo(fileStream);
                        }

                        pr.Product.Image = fileName + extension;
                    }
                    else
                    {
                        pr.Product.Image = prodFromDb.Image;
                    }
                    _db.Products.Update(pr.Product);
                }
            }
            this._db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var product = _db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            ProductViewModel productViewModel = new ProductViewModel()
            {
                Product = product,
                Categories = _db.Categories.Select(x => new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.CategoryId.ToString()
                })
            };

            return View("Redact", productViewModel);
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

            var product = _db.Products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            string uploadImg = _webHostEnvironment.WebRootPath + WebConstants.ProductImagePath;
            string oldFile = Path.Combine(uploadImg + product.Image);

            if (System.IO.File.Exists(oldFile))
            {
                System.IO.File.Delete(oldFile);
            }

            _db.Products.Remove(product);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
