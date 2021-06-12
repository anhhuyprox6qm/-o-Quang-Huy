using System;
using System.Collections.Generic;

namespace Lab3_1
{
    public class Atom
    {
        public int Number { get; set; }
        public string Symbol { get; set; }
        public string Fullname { get; set; }
        public double Weight { get; set; }
        private List<Atom> _listAtomic = new List<Atom>();

        public bool Accept()
        {
            Console.WriteLine("Enter atomic number : ");
            this.Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter symbol : ");
            this.Symbol = Console.ReadLine();
            Console.WriteLine("Enter full name : ");
            this.Fullname = Console.ReadLine();
            Console.WriteLine("Enter atomic weight : ");
            this.Weight = Convert.ToDouble(Console.ReadLine());
            _listAtomic.Add(this);
            return true;
        }

        public void Display()
        {
            for (int i = 0; i < _listAtomic.Count; i++)
            {
                Atom atom = _listAtomic[i];
                Console.WriteLine($"{Number},{Symbol},{Fullname},{Weight}");
                if (_listAtomic.Count>10)
                {
                    Console.WriteLine("Only get up to 10 elements!");
                    break;
                    int choice = int.Parse(Console.ReadLine());
                    if (choice !=1)
                    {
                        
                    }
                }
            }
        }
    }
   
}