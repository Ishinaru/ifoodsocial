using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IfoodSocial.Model
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Cod_Cliente { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string ?Nome_Cliente { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string ?Dcr_Endereco { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string ?Dcr_Complemento { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string ?Num_Cep { get; set; }

        [ForeignKey("Cod_Cidade")]
        public virtual Cidade Cidade { get; set; }

        [ForeignKey("Cod_Bairro")]
        public virtual Bairro Bairro { get; set; }
    }
}