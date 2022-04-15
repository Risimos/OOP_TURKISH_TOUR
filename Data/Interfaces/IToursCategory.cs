using oopQQ.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopQQ.Data.Interfaces
{
    public interface IToursCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
