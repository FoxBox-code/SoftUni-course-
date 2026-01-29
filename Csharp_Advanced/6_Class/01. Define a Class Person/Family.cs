using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            people = new List<Person>();
        }



        

        public void Addperson(Person person)
        {
            people.Add(person);
        }

        public Person GetOldestMember()
        {
            return people.MaxBy(x => x.Age);

        }
        public List<Person> OlderThanThirty()
        {
            List<Person> olderThan30 = new List<Person>();
            foreach (Person person in people)
            {
                if (person.Age > 30)
                {
                    olderThan30.Add(person);
                }
            }
            return olderThan30;
        }
    }
}
