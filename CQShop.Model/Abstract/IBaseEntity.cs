using System;
namespace CQShop.Model.Abstract
{
    public interface IBaseEntity
    {
        string MetakeyWord { set; get; }
        string metaDescription { set; get; }
        DateTime CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }
        bool Status { set; get; }
    }
}
