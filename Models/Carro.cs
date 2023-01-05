using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace locacao.Models
{
    [Table("carros")]
    public class Carro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;

        [Required(ErrorMessage = "O nome é obrigátrio")]
        [Column("nome", TypeName = "varchar(100)")]
        public string Nome { get; set; } = default!;

        [Required(ErrorMessage = "O Modelo é obrigátrio")]
        [Column("modelo", TypeName = "int")]
        public int ModeloId { get; set; } = default!;

        [Column("marca",TypeName = "int")]
        [Required(ErrorMessage = "A marca é obrigátria")]
        public int MarcaId { get; set; } = default!;
    }
}
