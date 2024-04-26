using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLivro.Models
{
    [Table("Emprestimos")]
    public class Emprestimo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A data de empréstimo é obrigatória.")]
        public DateTime DataEmprestimo { get; set; }

        public Livro Livro { get; set; }

        public Emprestimo()
        {
            
        }

        public Emprestimo(Livro livro, DateTime dataEmprestimo)
        {
            Livro = livro;
            DataEmprestimo = dataEmprestimo;
        }
    }
}