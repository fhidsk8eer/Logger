using Domain.Abstractions;

namespace Domain.Loggers;

public class MultipleUserLogger : ILogger
{
    private IPrinter _printer;

    public MultipleUserLogger(IPrinter printer)
    {
        if (printer == null)
            throw new ArgumentNullException("printer");
        
        _printer = printer;
    }


    public void Log(IEnumerable<User> users)
    {
        _printer.Print($"There are multiple users available:");
        users.ToList()
            .ForEach(x => _printer.Print(x.ToString()));
    }
}