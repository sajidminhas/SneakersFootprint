using Microsoft.AspNetCore.Mvc;
using SneakersFootprint.Models;
using SneakersFootprint.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakersFootprint.Controllers
{
    public class SneakerController : Controller
    {
        private readonly ISneakerRepository _sneakerRepository;
        private readonly ICategoryRepository _categoryRepository;

        public SneakerController(ISneakerRepository sneakerRepository, ICategoryRepository categoryRepository)
        {
            _sneakerRepository = sneakerRepository;
            _categoryRepository = categoryRepository;
        }

        //public iactionresult list()
        //{
        //    sneakerslistviewmodel sneakerslistviewmodel = new sneakerslistviewmodel();
        //    sneakerslistviewmodel.snearkers = _sneakerrepository.allsneakers;

        //    sneakerslistviewmodel.currentcategory = "men sneakers";
        //    return view(sneakerslistviewmodel);
        //}
        public ViewResult List(string category)
        {
            IEnumerable<Sneaker> sneakers;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                sneakers = _sneakerRepository.AllSneakers.OrderBy(s => s.SneakerId);
                currentCategory = "All sneakers";
            }
            else
            {
                sneakers = _sneakerRepository.AllSneakers.Where(s => s.Category.CategoryName == category)
                    .OrderBy(s => s.SneakerId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new SneakersListViewModel
            {
                Sneakers = sneakers,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var sneaker = _sneakerRepository.GetSneakerById(id);
            if (sneaker == null)
                return NotFound();
            return View(sneaker);
        }
    }
}
