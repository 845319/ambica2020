using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class car
    {
        string regno;
        string model;
        string color;
        double price;

        public car()
        { }

        public car(string reg)
        {
            regno = reg;

        }
        public car(string mod,string col)
        {
            model = mod;
            color = col;
        }
        public car(string col,string mod,string reg,double price)
        {
            model = mod;
            color = col;
            regno = reg;
            this.price = price;
        }
        public void showcar()
        {
            Console.WriteLine("reg no is: " + regno);
            Console.WriteLine("color is: " + color);
            Console.WriteLine("Model is: " + model);
            Console.WriteLine("Price is: " + price);
        }
      
    }
}
