using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HocLichSuDiaLy.Models
{
    public class Category
    {
        [Display(Name = "Mã thể loại")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Giá trị này không được bỏ trống")]
        [Display(Name = "Tên thể loại ")]
        public string Name { get; set; }
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        public virtual ICollection<Content> Contents{ get; set; }
    }
}
 