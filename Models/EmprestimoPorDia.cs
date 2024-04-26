using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLivro.Models
{
    [Table("EmprestimosPorDia")]
    public class EmprestimoPorDia : Emprestimo, IEmprestimo
    {
        [Key]
        public new int Id { get; set; }

        [Required(ErrorMessage = "A quantidade de dias do empréstimo é obrigatória.")]
        public int QuantidadeDias { get; set; }

        public Livro Livro { get; set; }

        public EmprestimoPorDia()
        {
            Livro = new Livro(); 
        }

        public EmprestimoPorDia(Livro livro, DateTime dataEmprestimo, int quantidadeDias) : base(livro, dataEmprestimo)
        {
            QuantidadeDias = quantidadeDias;
            Livro = livro;
        }

        public int CalcularDiasDeEmprestimo()
        {
            return QuantidadeDias;
        }
    }
}


