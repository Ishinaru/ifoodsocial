using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IfoodSocial.Model
{
    [Table("Cidade")]
    public class Cidade
    {
        [Key]
        public int Cod_Cidade { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string ? Dcr_Cidade { get; set; }

        public virtual ICollection<Empreedimento>? Empreedimentos { get; set; }
        public virtual ICollection<Bairro>? Bairros { get; set; }
    }
}