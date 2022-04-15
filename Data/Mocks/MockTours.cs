using oopQQ.Data.Interfaces;
using oopQQ.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopQQ.Data.Mocks
{
    public class MockTours : IAllTours
    {
        private readonly IToursCategory _categoryTours = new MockCategory();
        public IEnumerable<Tour> Tours
        {
            get
            {
                return new List<Tour>
                {
                   new Tour { 
                       Name="Название1",
                       Short_Description ="краткое описание 1", 
                       Long_Description="длинное описание 1",
                       Img="https://turkeyforfriends.com/_pu/53/35719786.jpg", 
                       Price=45000},

                    new Tour { 
                        Name = "Название2", 
                        Short_Description = "краткое описание 2",
                        Long_Description = "длинное описание 2", 
                        Img = "https://resortturkey.ru/wp-content/uploads/2020/06/shtoznat-bezop.jpeg", 
                        Price = 50000 }
                };
            }
        }

        IEnumerable<Tour> IAllTours.Tours { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Tour getObjectTour(Guid tourId)
        {
            throw new NotImplementedException();
        }
    }
}
