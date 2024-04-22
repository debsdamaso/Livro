using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLivro.Models
{
    [Table("EmprestimosPorDia")]
    public class EmprestimoPorDia : Emprestimo, IEmprestimo
    {
        private int _quantidadeDias;

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A quantidade de dias do empréstimo é obrigatória.")]
        public int QuantidadeDias
        {
            get { return _quantidadeDias; }
            set { _quantidadeDias = value; }
        }

        public EmprestimoPorDia()
        {
            // Construtor vazio necessário para o Entity Framework Core
        }

        public EmprestimoPorDia(Livro livro, DateTime dataEmprestimo, int quantidadeDias) : base(livro, dataEmprestimo)
        {
            _quantidadeDias = quantidadeDias;
        }

        // Método para calcular a quantidade de dias do empréstimo
        public int CalcularDiasDeEmprestimo()
        {
            return _quantidadeDias;
        }
    }
}
