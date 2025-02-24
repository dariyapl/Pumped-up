using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PumpedUp.Models;

namespace PumpedUp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<ITrackable> logs = new List<ITrackable>
            {
                new FoodLog(1, 101, "־לכוע", 250, DateTime.Now),
                new WorkoutLog(2, 101, "ֱ³ד", 500, DateTime.Now),
                new Goals(3, 101, 2000, 75, DateTime.Now.AddMonths(1))
            };

            return View(logs);
        }
    }
}
