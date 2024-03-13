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

        // Método para adicionar um livro à lista
        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        // Outros métodos e propriedades podem ser adicionados conforme necessário
    }

    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int AnoPublicacao { get; set; }
    }
}
