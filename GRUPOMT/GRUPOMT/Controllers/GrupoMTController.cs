using GRUPOMT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GRUPOMT.Controllers
{
    public class GrupoMTController : Controller
    {
     
        public IActionResult GrupoMT()
        {
            return View();
        }

     


 

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
