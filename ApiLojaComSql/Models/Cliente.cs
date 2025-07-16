using System.ComponentModel.DataAnnotations;

namespace ApiLojaComSql.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O e-mail do cliente é obrigatório.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "O telefone do cliente é obrigatório.")]
        public string Telefone { get; set; } = string.Empty;

        [Required]
        public bool Ativo { get; set; }
    }
}