using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IfoodSocial.Model
{
    [Table("Empreendimento")]
    public class Empreedimento
    {
        [Key]
        public int Cod_Empreedimento { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string ? Dcr_Empreendimento { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string ? Dcr_Nome_Fantasia { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string ? Dcr_Endereco { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string ? Dcr_Complemento { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string ? Num_Cep { get; set; }

        [ForeignKey("Cod_Cidade")]
        public virtual Cidade Cidade { get; set; }

        [ForeignKey("Bairro_Cod_Bairro")]
        public virtual Bairro Bairro { get; set; }

        public byte[]? Img_Empreendimento { get; set; }

        public virtual ICollection<Produto>? Produtos { get; set; }

        public virtual ICollection<Empreedimento>? Empreedimentos { get; set; }
    }
}