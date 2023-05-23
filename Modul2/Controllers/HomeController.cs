using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modul2.Models;

namespace Modul2.Controllers
{
    public class HomeController : Controller
    {
        private FarmLand[] plots = {
            new FarmLand {PlotNumber = 1, Area = 54.5, IsIrrigated = true, Crop = "Кукуруза", Fertilizer = "Аммиачная вода"},
            new FarmLand {PlotNumber = 2, Area = 452.1, IsIrrigated = false, Crop = "Пшеница", Fertilizer = "Натриевая селитра"},
            new FarmLand {PlotNumber = 3, Area = 125.0, IsIrrigated = false, Crop = "Рис", Fertilizer = "Кальциевая селитра"},
            new FarmLand {PlotNumber = 4, Area = 154.25, IsIrrigated = true, Crop = "Картошка", Fertilizer = "Аммиачная селитра"},
            new FarmLand {PlotNumber = 5, Area = 245.5, IsIrrigated = true, Crop = "Чечевица", Fertilizer = "Аммиачная вода"},
        };

        private Crop[] crops = {
            new Crop {Name = "Кукуруза", Yield = 12545.1, RequiresIrrigation = true, RequiredFertilizers = "Аммиачная вода"},
            new Crop {Name = "Пшеница", Yield = 14814.4, RequiresIrrigation = false, RequiredFertilizers = "Кальциевая селитра"},
            new Crop {Name = "Рис", Yield = 11001.21, RequiresIrrigation = true, RequiredFertilizers = "Аммиачная селитра"},
            new Crop {Name = "Картошка", Yield = 24155.1, RequiresIrrigation = true, RequiredFertilizers = "Натриевая селитра"},
            new Crop {Name = "Чечевица", Yield = 44575.1, RequiresIrrigation = false, RequiredFertilizers = "Аммиачная вода"},
        };

        public ActionResult Lands()
        {
            return View(plots);
        }

        public ActionResult CropDetails()
        {
            return View(crops);
        }

        public ActionResult CrewDetails()
        {
            return PartialView("_CrewDetails");
            //return PartialView("_CrewDetails", crew);
        }
    }
}