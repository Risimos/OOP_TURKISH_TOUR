using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopQQ.Data.Models
{
    public class Tour //тут самии туры
    {
        public Guid Id { get; set; } //id тура
        public string Name { get; set; } //название тура
        public string Short_Description { get; set; } //краткое описание
        public string Long_Description { get; set; } //длинное описание
        public string Img {get;set;} // изображение юрл адрес 
        public ushort Price { get; set; } //цена
        public int CategoryId { get; set; } 
        public Category Category { get; set; } //к какой категории относится тур т.е. id категории и ее название, описание
    }
}
