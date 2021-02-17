using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvc_mom2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_mom2.Controllers
{
    public class HomeController : Controller
    {

        // get för att hämta data
        [HttpGet]
        public IActionResult Index()
        {
            string sessionVar3 = HttpContext.Session.GetString("namnet");
            ViewBag.savedInput = sessionVar3;
            return View();
        }

        
        // Formulär hämtar med httppost
        [HttpPost]
        public IActionResult Index(IFormCollection formColl)
        {
            string input = formColl["namnInput"];
            string sessionVar = input;
            HttpContext.Session.SetString("namnet", sessionVar);
            ViewBag.savedInput = input;
            return View();
        }
       

        // 

        // ändrad routing
        [Route("blog")]
        public IActionResult Blog()
        {
            string sessionVar2 = HttpContext.Session.GetString("namnet");
            ViewBag.savedInput = sessionVar2;
            List<Skoter> personer3 = new List<Skoter>
            {
                new Skoter("Polaris", "SKS 850"),
                new Skoter("Lynx", "Boondocker 800"),
                new Skoter("Ski doo", "Summit X 800"),
            };

            ViewModel vm = new ViewModel
            {
                SkoterLista = personer3
            };
            return View(vm);
        }

        [Route("kontakt")]
        [HttpPost]
        public IActionResult Contact(IFormCollection formColl)
        {


            var areaobject = new Area();
            areaobject.lenght = Convert.ToInt32(formColl["lenght"]);
            areaobject.width = Convert.ToInt32(formColl["width"]);
            areaobject.dimension = formColl["dimension"];

            int lenght = areaobject.lenght;
            int width = areaobject.width;

            int rawanser = (lenght * width);

            ViewBag.Result = rawanser;
            ViewData["areaMeasure"] = areaobject.dimension;
            
           
            return View();


            //return View();
        }
        
        [Route("kontakt")]
        public IActionResult Contact()
        {


            string sessionVar3 = HttpContext.Session.GetString("namnet");
            ViewBag.savedInput = sessionVar3;

            // out till formulär
            string sessionArea2 = HttpContext.Session.GetString("areaA");
            ViewBag.ut = sessionArea2;

            return View();
        }



        public IActionResult _Layout()
        {
            string sessionVar3 = HttpContext.Session.GetString("namnet");
            ViewBag.sessiontest = sessionVar3;
            return View();
        }
    }
}
