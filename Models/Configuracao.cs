using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace locacao.Models
{
    public class Configuracao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;
        [Required(ErrorMessage = "Dias de locação é obrigatório")]
        [Column("diasDeLocacao", TypeName = "int")]
        public int DiasDeLocacao { get; set; } = default!;

    }
}
