namespace ProjetoBiblioteca.Models
{
    public abstract class Emprestimo
    {
        public int Id { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataEmprestimo { get; set; }

        protected Emprestimo(Livro livro, DateTime dataEmprestimo)
        {
            Livro = livro;
            DataEmprestimo = dataEmprestimo;
        }

        public abstract int CalcularDiasDeEmprestimo();
    }
}
