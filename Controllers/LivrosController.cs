using Microsoft.AspNetCore.Mvc;
using ProjetoLivro.Models;
using System.Collections.Generic;

public class LivrosController : Controller
{
    public IActionResult Index()
    {
        // Inicializar lista de livros
        var livros = new List<Livro>
        {
            new Livro { Titulo = "O Senhor dos Anéis", Autor = new Autor { Nome = "J.R.R. Tolkien" }, Editora = new Editora { Nome = "HarperCollins" }, AnoPublicacao = 1954 },
            new Livro { Titulo = "1984", Autor = new Autor { Nome = "George Orwell" }, Editora = new Editora { Nome = "Seix Barral" }, AnoPublicacao = 1949 }
        };

        return View(livros);
    }
}