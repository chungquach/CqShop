﻿using CQShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace CQShop.Model.Models
{
    [Table("Products")]
    public class Product : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Required]
        [MaxLength(250)]
        public string Name { set; get; }

        [Required]
        [MaxLength(250)]
        [Column(TypeName ="varchar")]
        public string Alias { set; get; }

        [Required]
        public int CategoryId { set; get; }
        
        [MaxLength(256)]
        public string Image { set; get; }

        public XElement MoreImage { set; get; }

        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { set; get; }
    }
}
