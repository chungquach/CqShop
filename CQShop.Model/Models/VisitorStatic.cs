using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CQShop.Model.Models
{
    [Table("VisitorStatics")]
    public class VisitorStatic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        public DateTime VisitorDate { set; get; }

        [MaxLength(50)]
        public string IPAdress { set; get; }
    }
}
