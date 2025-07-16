using System.ComponentModel.DataAnnotations;

namespace ApiLojaComSql.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O ID do cliente é obrigatório.")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "O ID do produto é obrigatório.")]
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "A quantidade é obrigatória.")]
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser maior do que 0.")]
        public int Quantidade { get; set; }
    }
}