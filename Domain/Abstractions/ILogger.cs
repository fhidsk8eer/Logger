namespace Domain.Abstractions;

public interface ILogger
{
    void Log(IEnumerable<User> users);
}