using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Entities;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> Products = new List<Product> { new Product { Id=1,Name="Box",Description="A large box",Price=8,Discount=10 }, new Product { Id = 2, Name = "Box", Description = "A large box", Price = 8, Discount = 10 }, new Product { Id = 3, Name = "Box", Description = "A large box", Price = 8, Discount = 10 }, new Product { Id = 4, Name = "Box", Description = "A large box", Price = 8, Discount = 10 }, new Product { Id = 5, Name = "Box", Description = "A large box", Price = 8, Discount = 10 }, new Product { Id = 6, Name = "Box", Description = "A large box", Price = 8, Discount = 10 } };

        public IActionResult Index()
        {
            var vm = new ProductListViewModel
            {
                Products = Products
            };
            return View(vm);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var vm = new ProductAddViewModel
            {
                Product = new Product()
            };

            return View(vm);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var prod = Products.SingleOrDefault(p=>p.Id== id);
            if (prod != null)
            {
                Products.Remove(prod);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = Products.SingleOrDefault(p => p.Id == id);
            if (product != null)
            {
                var vm = new ProductUpdateViewModel
                {
                    Product = product
                };
                return View(vm);

            }
            return RedirectToAction("Index");
        
        }

        [HttpPost]
        public IActionResult Add(ProductAddViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Products.Add(vm.Product);
                return RedirectToAction("Index");
            }
            else { return View(vm); }
        }

        [HttpPost]
        public IActionResult Update(ProductUpdateViewModel vm, int id)
        {
            if (ModelState.IsValid)
            {
                var product = Products.SingleOrDefault(p => p.Id == id);
                if (product != null)
                {
                    product.Name = vm.Product.Name;
                    product.Description = vm.Product.Description;
                    product.Price = vm.Product.Price;
                    product.Discount = vm.Product.Discount;
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(vm);
            }
        }



    }
}
