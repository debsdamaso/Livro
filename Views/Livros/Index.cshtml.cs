using System.Collections.Generic;

namespace ProjetoLivro.ViewModels
{
    public class LivrosViewModel
    {
        public List<Livro> Livros { get; set; }

        public LivrosViewModel()
        {
            Livros = new List<Livro>();
        }

        // M�todo para adicionar um livro � lista
        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        // Outros m�todos e propriedades podem ser adicionados conforme necess�rio
    }

    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int AnoPublicacao { get; set; }
    }
}
