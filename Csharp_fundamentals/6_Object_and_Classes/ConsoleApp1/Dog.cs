using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dog
    {
        public string Name { get; set; } // This is called propertie
        public string Breed { get; set; }// This is called propertie
        public int Age { get; set; }// This is called propertie


        public void Bark()
        {
            Console.WriteLine("Bark,Bark....");
        }
    }
}
