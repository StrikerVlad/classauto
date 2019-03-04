using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class auto
    {
        protected string model { get; set; }
        protected string brand { get; set; }
        protected double MaxSpeed { get; set; }
        protected double Razgondo100 { get; set; }
        protected int year { get; set; }


        static readonly string Wincode;

        public double GetMaxSpeed()
        {
            return this.MaxSpeed;
        }

        public void RachetGar(int year)
        {
            if (year < 2000)
            {
                Console.WriteLine("Гарантия не действует");
            }

            else if (year > 2000 && year < 2010)
            {
                Console.WriteLine("Гарантия по решению салона");
            }

            else
            {
                Console.WriteLine("Полное покрытие гарантии");
            }
        }

        public auto(string model, string brand, int year)
        {
            this.model = model;
            this.brand = brand;
            this.year = year;
        }

        public auto()
        {
            this.model = model;
            this.brand = brand;
            this.year = year;
        }

             
    }
}
