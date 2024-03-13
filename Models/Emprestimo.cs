namespace ProjetoLivro.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        internal DateTime DataDeDevolucao { get; set; }

        // Construtor que aceita um livro e uma data de empréstimo
        public Emprestimo(Livro livro, DateTime dataEmprestimo)
        {
            Livro = livro;
            DataEmprestimo = dataEmprestimo;
        }

        public virtual int CalcularDiasDeEmprestimo()
        {
            // Implementação padrão para calcular dias de empréstimo
            return 14; // Exemplo de retorno padrão
        }

        // Método internal para definir a data de devolução
        internal void DefinirDataDeDevolucao(DateTime dataDeDevolucao)
        {
            DataDeDevolucao = dataDeDevolucao;
        }
    }
}