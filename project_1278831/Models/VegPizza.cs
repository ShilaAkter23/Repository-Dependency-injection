using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project_1278831.Models
{
    public class VegPizza : Pizza
    {
        public VegPizza() { }
        public VegPizza(int id, string name, string size, double price, string stock)
        {
            this.Id = id;
            this.Name = name;
            this.Size = size;
            this.Price = price;
            this.Stock = stock;
        }
        public string Name { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public string Stock { get; set; }
    }
}
