using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = 'MyCafe';
            return View();
        }
        public ViewResult DrinkForm()
        {
            ViewBag.Title = 'Drinks';
            return View();
        }
    [HttpPost]
    public ViewResult DrinkForm(DrinkData drinkData)
        { 
          if (ModelState.IsValid)
        {
            ViewBag.Title = "Bill";
            //Определить стоимость напитка и вернуть в ViewBag.Cost 
            ViewBag.Cost = 150;
            return View("Bill", drinkData);
        } 
    else 
    {
    return View();
    }
    }

}