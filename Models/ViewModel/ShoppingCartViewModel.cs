using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HocLichSuDiaLy.Models.ViewModel
{
    public class ShoppingCartViewModel
    {
        public List<Content> contents { get; set; }
        public OrderContent orderContent { get; set; }
    }
}
 