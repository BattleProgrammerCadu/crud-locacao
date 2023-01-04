using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace locacao.Models
{
    public class Cliente
    {
        //(id, nome, email, telefone, endereco)
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;

        [Required(ErrorMessage = "Nome é obrigatório")]
        [Column("nome", TypeName = "varchar(100)")]
        public string Nome { get; set; } = default!;


        [Required(ErrorMessage = "Email é obrigatório")]
        [Column("email", TypeName = "varchar(150)")]
        public string Email { get; set; } = default!;

        [Column("endereco", TypeName = "text")]
        public string? Endereco { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        [Column("telefone", TypeName = "varchar(12)")]
        public string Telefone { get; set; } = default!;
    }
}
