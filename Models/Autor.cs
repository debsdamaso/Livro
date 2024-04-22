using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLivro.Models
{
    [Table("Autores")]
    public class Autor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do autor é obrigatório.")]
        public string Nome { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}