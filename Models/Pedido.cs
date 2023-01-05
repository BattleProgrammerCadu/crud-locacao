using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace locacao.Models
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;
        [Required]
        [Column("idCliente", TypeName = "int")]
        public int IdCliente { get; set; } = default!;
        [Required]
        [Column("carro",TypeName = "int")]
        public int Carro { get; set; } = default!;
        [Required]
        [Column("dataLocacao", TypeName ="Date")]
        public DateTime DataLocacao { get; set; } = default!;
        [Required]
        [Column("dataEntrega", TypeName = "Date")]
        public DateTime DataEntrega { get; set; } = default!;
    }
}
/*
 * 
 * Pedido(id, idcliente, carro, dataLocacao, dataEntrega)
 * */