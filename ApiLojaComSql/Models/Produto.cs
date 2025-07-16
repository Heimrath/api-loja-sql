using System.ComponentModel.DataAnnotations;

namespace ApiLojaComSql.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        public string Nome { get; set; } = string.Empty;

        [Range(0.01, 99999.99, ErrorMessage = "Digite um preço no intervalo: 0.01 - 99999.99.")]
        public decimal Preco { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = $"O estoque deve ser maior do que 0.")]
        public int Estoque { get; set; }
    }
}