using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _24x7Store.Models;

namespace _24x7Store.ViewModel
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }

       public string CurrentCategory { get; set; }
        public string Price { get; set; }

        public bool Stock { get; set; }

        public int CategoryId { get; set; }
    }

}
