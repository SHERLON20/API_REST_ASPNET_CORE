using project_net.Model;

namespace project_net.Services
{
    public interface IPersonServices
    {
        Person Create(Person person);
        Person findById(long id);
        List<Person> findAll();
        Person Updadate(Person person);
        void Delete(long id);
    }
}
