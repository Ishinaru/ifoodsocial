using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IfoodSocial.Model
{
    [Table("Bairro")]
    public class Bairro
    {
        [Key]
        public int Cod_Bairro { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string ? Dcr_Bairro { get; set; }

        [ForeignKey("Cod_Cidade")]
        public virtual Cidade Cidade { get; set; }

        public virtual ICollection<Cliente>? Clientes { get; set; }
    }
}