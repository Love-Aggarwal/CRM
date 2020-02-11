using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _24x7Store.Models
{
    public class MockPieRepository: IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {
                    PieID = 1, 
                    Name="Strawberry Pie",
                    Price=15.95M, 
                    ShortDescription="Lorem Ipsum", 
                    LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 
                    AllergyInfromation = "None", 
                    Instock=true, 
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", 
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                    Category = _categoryRepository.AllCategories.ToList()[0],
                    CategoryId=102, 
                    IsPieOfTheWeek=true
                },
                 new Pie {
                    PieID = 2,
                    Name="Chocolate Pie",
                    Price=18.95M,
                    ShortDescription="Lorem Ipsum",
                    LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    AllergyInfromation = "None",
                    Instock=true, 
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                    Category = _categoryRepository.AllCategories.ToList()[1],
                    CategoryId=101,
                    IsPieOfTheWeek=true
                },
                  new Pie {
                    PieID = 3,
                    Name="Pineapple Pie",
                    Price=15.95M,
                    ShortDescription="Lorem Ipsum",
                    LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    AllergyInfromation = "None",
                    Instock=true, 
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                    Category = _categoryRepository.AllCategories.ToList()[2],
                    CategoryId=103,
                    IsPieOfTheWeek=true
                },
                   new Pie {
                    PieID = 4,
                    Name="Coconut Pie",
                    Price=20.03M,
                    ShortDescription="Lorem Ipsum",
                    LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    AllergyInfromation = "None",
                    Instock=true,
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                    Category = _categoryRepository.AllCategories.ToList()[0],
                    CategoryId=103,
                    IsPieOfTheWeek=true
                },
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieID == pieId);
        }
    }
}
