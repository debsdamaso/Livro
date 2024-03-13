namespace ProjetoLivro.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Autor Autor { get; set; }
        public Editora Editora { get; set; }
        public int AnoPublicacao { get; set; }
        public bool Emprestado { get; set; }

        protected void AtualizarStatus(bool emprestado)
        {
            Emprestado = emprestado;
        }
    }
}
