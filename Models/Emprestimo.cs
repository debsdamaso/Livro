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

        public int LivroId { get; set; }

        public virtual Livro Livro { get; set; }
    }
}
