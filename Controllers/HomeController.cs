using Microsoft.AspNetCore.Mvc;
using DotNetQueryApp.Models;

namespace DotNetQueryApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string query)
        {
            var model = new QueryParameterModel
            {
                QueryValue = query
            };
            return View(model);
        }
    }
}