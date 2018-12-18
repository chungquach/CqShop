using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CQShop.Model.Models
{
    [Table("Tags")]
    class Tag
    {
        [Key]
        [MaxLength(50)]
        public string Id { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(50)]
        public string Type { set; get; }
    }
}
