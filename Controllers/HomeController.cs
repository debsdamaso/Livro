using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoLivro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Obtém todas as views disponíveis no projeto
            var viewFiles = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "Views"), "*.cshtml", SearchOption.AllDirectories);

            // Remove o caminho absoluto dos nomes dos arquivos
            var viewNames = viewFiles.Select(file => Path.GetRelativePath(Path.Combine(Directory.GetCurrentDirectory(), "Views"), file));

            // Remove a extensão .cshtml dos nomes dos arquivos
            viewNames = viewNames.Select(view => view.Replace(".cshtml", string.Empty));

            return View(viewNames);
        }
    }
}

