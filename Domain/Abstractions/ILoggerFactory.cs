namespace Domain.Abstractions;

public interface ILoggerFactory
{
    ILogger Create(IEnumerable<User> users);
}