using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _24x7Store.Models
{
   public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
