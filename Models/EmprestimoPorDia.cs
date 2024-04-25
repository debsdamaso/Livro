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

        // Correção: Inicializar a propriedade Livro no construtor
        public Livro Livro { get; set; }

        // Correção: Adicionar um construtor para inicializar a propriedade Livro
        public EmprestimoPorDia()
        {
            Livro = new Livro(); // ou inicialize com o livro desejado
        }

        // Correção: Modificar a assinatura do construtor para corresponder à classe base
        public EmprestimoPorDia(Livro livro, DateTime dataEmprestimo, int quantidadeDias) : base(livro, dataEmprestimo)
        {
            QuantidadeDias = quantidadeDias;
            Livro = livro;
        }

        // Método para calcular a quantidade de dias do empréstimo
        public int CalcularDiasDeEmprestimo()
        {
            return QuantidadeDias;
        }
    }
}


