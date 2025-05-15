using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HocLichSuDiaLy.Models
{
    public class OrderContentDetail

    {
        [Display(Name = "Mã chi tiết bài viết")]
        [ForeignKey("OrderContent")]
        public int OrderContentID { get; set; }

        [Display(Name = "Mã bài viết")]
        [ForeignKey("Content")]
        public int ContentID { get; set; }
         
        //[Display(Name = "Số lượng")]
        //public int Quantities { get; set; }

        [Display(Name = "Tên bài viết")]
        public virtual Content Content { get; set; }

        [Display(Name = "Mã truy cập")]
        public virtual OrderContent OrderContent { get; set; }
    }
}
