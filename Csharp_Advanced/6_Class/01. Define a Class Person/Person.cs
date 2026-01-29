using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace DefiningClasses

{
    public class Person
    {
        private string name; // Fields
        private int age;


        public Person() // Constructors  // ctor will make us automaticlly 
        {
            Name = "No name";
            age = 1;
            
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            

        }
        public Person(int age)
        {
            Name = "No name";
            Age = age;
           
        }

        
        public string Name // Property
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;

            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        
    }
}
