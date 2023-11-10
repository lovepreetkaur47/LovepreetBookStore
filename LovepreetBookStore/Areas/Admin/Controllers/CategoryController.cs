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
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id) //Action to upsert
        {
            Category category = new Category(); //using LovepreetBook.Model
            if (id == null)
            {
                //this is for create
                return View(category);
            }
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        //Https post to define the post-action method
        //API calls here
        #region
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(Category category)
        {
            if(ModelState.IsValid) //checks all validations in model
            {
                if(category.Id == 0)
                {
                    _unitOfWork.Category.Add(category);
                    
                }
                else
                {
                    _unitOfWork.Category.Update(category);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index)); //see all th categories


            }
            return View(category);

        }
        public IActionResult GetAll()
        {
            //return NotFound
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(id);
            if(objFromDb == null)
            {
                return Json(new { success = true, message = "Error while deleting"})
            }
            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion
    }
}
