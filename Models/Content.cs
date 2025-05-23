﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HocLichSuDiaLy.Models
{
    public class Content
    {
        public int ContentID { get; set; }

        [Display(Name = "Tên bài viết")]
        public string Title { get; set; }

        [Display(Name = "Tóm tắt")]
        public string Summary { get; set; }
         
        [Display(Name = "Số lượng")]
        public int Quantities { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày xuất bản")]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày tái bản")]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "Số trang")]
        public int NumberOfPages { get; set; }

        [Display(Name = "Số lượng truy cập")]
        public Int64 Price { get; set; }

        [Display(Name = "Ảnh bìa")]
        public string ImageUrl { get; set; }

        [Display(Name = "Được phép truy cập")]
        public Boolean IsPurchase { get; set; }

        [Display(Name = "Tác giả")]
        public int AuthorID { get; set; }

        [Display(Name = "Thể loại")]
        public int CategoryID { get; set; }

        [Display(Name = "Nhà xuất bản")]
        public int PublisherID { get; set; }

        [Display(Name = "Tác giả")]
        public virtual Author Author { get; set; }

        [Display(Name = "Thể loại")]
        public virtual Category Category { get; set; }

        public virtual ICollection<OrderContentDetail> OrderContentDetails { get; set; }

        [Display(Name = "Tác giả")]
        public virtual Publisher Publisher { get; set; }
    }
}
