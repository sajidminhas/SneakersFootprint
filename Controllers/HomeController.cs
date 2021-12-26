using Microsoft.AspNetCore.Mvc;
using SneakersFootprint.Models;
using SneakersFootprint.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakersFootprint.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
          
            return View();
            
        }
       
    }
}
