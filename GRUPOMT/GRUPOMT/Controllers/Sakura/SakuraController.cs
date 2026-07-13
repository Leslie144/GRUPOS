using Microsoft.AspNetCore.Mvc;

namespace GRUPOMT.Controllers.Sakura
{
    public class SakuraController : Controller
    {
        // 2. Vista de Transportes Turísticos Sakura
        public IActionResult Sakura()
        {
            return View();
        }
    }
}
