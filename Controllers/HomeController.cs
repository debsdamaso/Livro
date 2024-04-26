using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoLivro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            var viewFiles = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "Views"), "*.cshtml", SearchOption.AllDirectories);

            
            var viewNames = viewFiles.Select(file => Path.GetRelativePath(Path.Combine(Directory.GetCurrentDirectory(), "Views"), file));

            
            viewNames = viewNames.Select(view => view.Replace(".cshtml", string.Empty));

            return View(viewNames);
        }
    }
}

