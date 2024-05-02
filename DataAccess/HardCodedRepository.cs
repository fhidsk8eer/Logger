using Domain;
using Domain.Abstractions;

namespace DataAccess;

public class HardCodedRepository : IRepository
{
    public IEnumerable<User> GetUsers()
    {
        return new[]
        {
            new User()
            {
                Name = "Max",
                LastName = "Nuñez"
            },
            new User()
            {
                Name = "Ivan",
                LastName = "Mireles"
            },
            new User()
            {
                Name = "Constanza",
                LastName = "Tapia"
            }
        };
    }
}