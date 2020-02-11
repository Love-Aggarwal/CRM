using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _24x7Store.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {

        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category
                {
                    CategoryID=101,
                    CategoryName="Fruit Pies",
                    Description="All-fruity Pies"
                },
                new Category
                {
                    CategoryID=102,
                    CategoryName="Cheese Cakes",
                    Description="cheesy all the day Pies"
                },
                new Category
                {
                    CategoryID=103,
                    CategoryName="Seasonal Pies",
                    Description="Get in the mood for seasonal Pies"
                },
            };
    }
}
