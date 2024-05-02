using DataAccess;
using Domain;
using Domain.Abstractions;
using Domain.Factories;
using UserInterface;

internal class Program
{
    public static void Main(string[] args)
    {
        var service = CompositionRoot();
        service.Operate();
    }

    private static IUserService CompositionRoot() =>
        new
            UserService(
                new LoggerFactory(
                    new ConsolePrinter()),
                new HardCodedRepository()
            );
}