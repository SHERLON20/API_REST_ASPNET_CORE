using project_net.Model;
using project_net.Model.context;

namespace project_net.Services.impl
{
    public class PersonServicesimpl : IPersonServices
    {
        private MSSQLcontext _context;
        public PersonServicesimpl(MSSQLcontext context)
        {
            _context = context;
        }
        public Person findById(long id)
        {
            return _context.Persons.Find(id);
        }


        public List<Person> findAll()
        {
            
            return _context.Persons.ToList();
        }
        public Person Create(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
            return person;
        }
        public Person Updadate(Person person)
        {
            var existingPerson = _context.Persons.Find(person.Id);
            if (existingPerson == null)
            {
                return null;
            }
            _context.Entry(existingPerson).CurrentValues.SetValues(person);
            _context.SaveChanges();
            return person;
        }

        public void Delete(long id)
        {
            var person = _context.Persons.Find(id);
            if (person != null)
            {
                _context.Persons.Remove(person);
                _context.SaveChanges();
            }
        }
        }
    }
