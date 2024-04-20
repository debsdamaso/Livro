namespace ProjetoBiblioteca.Models
{
    public class EmprestimoPorDia : Emprestimo, IEmprestimo
    {
        private int _quantidadeDias;

        public EmprestimoPorDia(Livro livro, DateTime dataEmprestimo, int quantidadeDias) : base(livro, dataEmprestimo)
        {
            _quantidadeDias = quantidadeDias;
        }

        public override int CalcularDiasDeEmprestimo()
        {
            return _quantidadeDias;
        }
    }
}
