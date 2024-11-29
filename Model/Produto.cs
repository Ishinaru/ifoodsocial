using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IfoodSocial.Model
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Cod_Produto { get; set; }

        [Column(TypeName ="varchar(45)")]
        public string? Dcr_Produto { get; set; }

        public byte[]? Img_Produto { get; set; }
        
        [Precision(9, 2)]
        public decimal? Vlr_Produto { get; set; }

        public char? Flag_Disponivel { get; set; }

        [ForeignKey("Cod_Categoria")]
        public virtual Categoria Categoria { get; set; }

        [ForeignKey("Cod_Empreedimento")]
        public virtual Empreedimento Empreedimento { get; set; }
    }
}
