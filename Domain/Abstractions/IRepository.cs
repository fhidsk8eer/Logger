namespace Domain.Abstractions;

public interface IRepository
{
    IEnumerable<User> GetUsers();
}