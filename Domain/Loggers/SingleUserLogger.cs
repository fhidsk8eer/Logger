using Domain.Abstractions;

namespace Domain.Loggers;

public class SingleUserLogger : ILogger
{
    private IPrinter _printer;

    public SingleUserLogger(IPrinter printer)
    {
        if (printer == null)
            throw new ArgumentNullException("printer");
        
        _printer = printer;
    }

    public void Log(IEnumerable<User> users)
    {
        _printer.Print($"There's only one user available:");
        users.ToList()
            .ForEach(x => _printer.Print(x.ToString()));
    }
}