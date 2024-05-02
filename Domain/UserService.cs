using Domain.Abstractions;

namespace Domain;

public class UserService : IUserService
{
    private ILoggerFactory _factory;
    private IRepository _repository;

    public UserService
        (ILoggerFactory factory,
            IRepository repository)
    {
        _factory = factory;
        _repository = repository;
    }

    public void Operate()
    {
        var users = _repository.GetUsers();
        var logger = _factory.Create(users);
        logger.Log(users);
    }
}