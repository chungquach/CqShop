﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CQShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        
        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAdress { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomerMobile { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }

        [Required]
        [MaxLength(256)]
        public string PaymentMethod { set; get; }


        public DateTime CreateDate { set; get; }
        public string CreateBy { set; get; }
        public string PaymentStatus { set; get; }
        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}
