using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQShop.Model.Abstract
{
    public class BaseEntity : IBaseEntity
    {
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [MaxLength(100)]
        [Required]
        public string CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [MaxLength(100)]
        public string UpdateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [MaxLength(250)]
        public string MetakeyWord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [MaxLength(250)]
        public string metaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

