using Domain.Abstractions;

namespace UserInterface;

public class ConsolePrinter: IPrinter
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }
}