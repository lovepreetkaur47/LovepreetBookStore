using LovepreetBook.DataAccess.Repository.IRepository;
using LovepreetBook.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LovepreetBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id) //Action to upsert
        {
            Product product = new Product(); //using LovepreetBook.Model
            if (id == null)
            {
                //this is for create
                return View(product);
            }
            product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        //Https post to define the post-action method
        //API calls here
        #region
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(Product product)
        {
            if (ModelState.IsValid) //checks all validations in model
            {
                if (product.Id == 0)
                {
                    _unitOfWork.Product.Add(product);

                }
                else
                {
                    _unitOfWork.Product.Update(product);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index)); //see all th categories


            }
            return View(product);

        }
        public IActionResult GetAll()
        {
            //return NotFound
            var allObj = _unitOfWork.Product.GetAll();
            return Json(new { data = allObj });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Product.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = true, message = "Error while deleting" });
            }
            _unitOfWork.Product.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion
    }
}

