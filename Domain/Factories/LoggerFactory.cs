using Domain.Abstractions;
using Domain.Loggers;

namespace Domain.Factories;

public class LoggerFactory : ILoggerFactory
{
    private IPrinter _printer;

    public LoggerFactory(IPrinter printer)
    {
        _printer = printer;
    }

    public ILogger Create(IEnumerable<User> users)
    {
        return users.Count() switch
        {
            1 => new SingleUserLogger(_printer),
            2 => new DoubleUserLogger(_printer),
            _ => new MultipleUserLogger(_printer)
        };
    }
}