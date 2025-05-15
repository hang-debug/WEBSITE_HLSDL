using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HocLichSuDiaLy.Models
{ 
    public class OrderContent

    {
        [Display(Name = "Mã truy cập")]
        public int OrderID { get; set; } 

        [Display(Name = "Ngày truy cập")]
        public DateTime AppointmentDate { get; set; }

        [NotMapped]
        [Display(Name = "Giờ truy cập")]
        public DateTime AppointmentTime { get; set; }

        [Display(Name = "Tên người truy cập")]
        public string VisitorName { get; set; }

        [Display(Name = "Địa chỉ ")]
        public string VisitorAddress { get; set; }

        [Display(Name = "Số điện thoại liên hệ")]
        public string VisitorPhone { get; set; }

        [Display(Name = "Xác nhận")]
        public Boolean isConfirmed { get; set; }
        public virtual ICollection<OrderContentDetail> OrderContentDetails { get; set; }
    }
}
