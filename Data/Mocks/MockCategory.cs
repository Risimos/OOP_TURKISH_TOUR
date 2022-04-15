using oopQQ.Data.Interfaces;
using oopQQ.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopQQ.Data.Mocks
{
    public class MockCategory : IToursCategory //реализует интерфейс toursCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{Name="Пляжный отдых",Description="Отдых на берегу черного моря"},
                    new Category{Name="Назад в прошлое",Description="Путешествие по историческим местам"}
                };
            }
        }
    }
}
