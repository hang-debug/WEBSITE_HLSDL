using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HocLichSuDiaLy.Models.ViewModel
{
    public class BookViewModel
    {
        public Content book { get; set; }
        public IEnumerable<Category> categories { get; set; }
        public IEnumerable<Author> authors { get; set; }
    }
} 
