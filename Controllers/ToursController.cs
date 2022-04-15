using Microsoft.AspNetCore.Mvc;
using oopQQ.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopQQ.Controllers
{
    public class ToursController:Controller
    {
        private readonly IAllTours _allTours;
        private readonly IToursCategory _toursCategory;

        public ToursController (IAllTours ialltours, IToursCategory itourscategory)
        {
            _allTours = ialltours;
            _toursCategory = itourscategory;
        }
        public ViewResult ListTour()
        {
            var tours = _allTours.Tours; //обращаемся к интерфейсу -> далее к функциии вывода чтобы получить список туров для вывода на страницу
            return View(tours);
        }
    }
}
