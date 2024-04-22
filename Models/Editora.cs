using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLivro.Models
{
    [Table("Editoras")]
    public class Editora
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da editora é obrigatório.")]
        public string Nome { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
