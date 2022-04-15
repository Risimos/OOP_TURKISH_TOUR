using oopQQ.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopQQ.Data.Interfaces
{
    public interface IAllTours
    {
        IEnumerable<Tour> Tours { get; set; }
        Tour getObjectTour(Guid tourId);
    }
}
