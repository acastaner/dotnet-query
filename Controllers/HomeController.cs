using Microsoft.AspNetCore.Mvc;
using DotNetQueryApp.Models;

namespace DotNetQueryApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string query)
        {
            var request = Request;
            string scheme = request.Scheme; // e.g., "http" or "https"
            string host = request.Host.Value; // e.g., "localhost:5000"
            string path = request.Path.Value; // e.g., "/demo/query/10"
            string queryString = request.QueryString.Value; // e.g., "?param=value"
            string fullUrl = $"{scheme}://{host}{path}{queryString}";

            var model = new QueryParameterModel
            {
                QueryValue = query,
                FullUrl = fullUrl
            };
            return View(model);
        }
    }
}