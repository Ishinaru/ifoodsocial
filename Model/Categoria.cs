using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IfoodSocial.Model
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int Cod_Categoria { get; set; }

        public string ? Dcr_Categoria { get; set; }

        public byte[] ? Img_Categoria { get; set; }

        [ForeignKey("Cod_Empreedimento")]
        public virtual Empreedimento Empreedimento { get; set; }

        public virtual ICollection<Produto>? Produtos { get; set; }

    }
}