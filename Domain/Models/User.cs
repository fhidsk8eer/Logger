namespace Domain;

public class User
{
    public string Name { get; set; }
    public string LastName { get; set; }


    public override string ToString()
    {
        return $"User: {Name} {LastName}";
    }
}