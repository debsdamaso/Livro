using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLivro.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do usu�rio � obrigat�rio.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email do usu�rio � obrigat�rio.")]
        [EmailAddress(ErrorMessage = "Formato de email inv�lido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O telefone do usu�rio � obrigat�rio.")]
        [Phone(ErrorMessage = "Formato de telefone inv�lido.")]
        public string Telefone { get; set; }
    }
}
