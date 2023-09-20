using RestWithASPNETUdmy.Model;

namespace RestWithASPNETUdmy.Services.Implementations
{
    public class PersonServiceImplemetation : IPersonService
    {
        private List<Person> persons = new List<Person>();
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> list = new List<Person>();
            for (int i = 0;i <8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }
          
        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "juca",
                LastName = "Abee",
                Address = "asdadad",
                Gender = "Male"

            };
        }

        public Person Update(Person person)
        {
           return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "person Name" + i,
                LastName = "person LastName" + i,
                Address = "Some Address" + i,
                Gender = "Male"

            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
