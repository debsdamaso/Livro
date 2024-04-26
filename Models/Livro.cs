using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLivro.Models
{
    [Table("Livros")]
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título do livro é obrigatório.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O ano de publicação do livro é obrigatório.")]
        public int AnoPublicacao { get; set; }

        public bool Emprestado { get; set; }

        public int AutorId { get; set; }

        [ForeignKey("AutorId")]
        public virtual Autor Autor { get; set; }

        public int EditoraId { get; set; }

        [ForeignKey("EditoraId")]
        public virtual Editora Editora { get; set; }

        
        public virtual ICollection<EmprestimoPorDia> Emprestimos { get; set; }
    }
}