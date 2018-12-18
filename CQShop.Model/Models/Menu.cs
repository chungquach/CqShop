﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CQShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        [Required]
        [MaxLength(50)]
        public string Name { set; get; }
        [Required]
        [MaxLength(256)]
        public string URL { set; get; }
        public int?  DisplayOrder { set; get; }
        [Required]
        public int GroupId { set; get; }
        [MaxLength(10)]
        public string Target { set; get; }
        public bool Status { set; get; }

        [ForeignKey("GroupId")]
        public virtual ManuGroup ManuGroup { set; get; }
    }
}
