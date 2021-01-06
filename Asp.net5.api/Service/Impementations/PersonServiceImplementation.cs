using Asp.net5.api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Asp.net5.api.Service.Impementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long Id)
        {
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson();
                persons.Add(person);

            }
            return persons;
        }

        private Person MockPerson(long? id = null)
        {
            return new Person
            {
                Id = id ?? IncrementAndGet(),
                FirstName = "Paulo",
                LastName = "Morais",
                Gender = "Male",
                Address = "Rua Caratinga,nº320"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindAllById(long Id)
        {
            return MockPerson(Id);

        }

        public Person Update(Person person)
        {
            return person;

        }
    }
}
