using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLivro.Models
{
    [Table("EmprestimosPorDia")]
    public class EmprestimoPorDia : Emprestimo, IEmprestimo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A quantidade de dias do empréstimo é obrigatória.")]
        public int QuantidadeDias { get; set; }

        public EmprestimoPorDia()
        {
            // Construtor vazio necessário para o Entity Framework Core
        }

        // aceitar dois argumentos
        public EmprestimoPorDia(Livro livro, DateTime dataEmprestimo, int quantidadeDias) : base(livro, dataEmprestimo)
        {
            QuantidadeDias = quantidadeDias;
        }

        // Método para calcular a quantidade de dias do empréstimo
        public int CalcularDiasDeEmprestimo()
        {
            return QuantidadeDias;
        }
    }
}

