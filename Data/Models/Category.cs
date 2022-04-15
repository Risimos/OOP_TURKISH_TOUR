using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopQQ.Data.Models
{
    public class Category //категории пляжный отдых и достопримечательности(т.е. все туры делим на две категории)
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Tour> tours { get; set; }
    }
}
