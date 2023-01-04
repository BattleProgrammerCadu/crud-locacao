using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace locacao.Models
{
    public class Modelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;
        [Required(ErrorMessage = "O nome é obrigátrio")]
        [Column("nome", TypeName = "varchar(100)")]
        public string Nome { get; set; } = default!;
    }
}
