namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        var newPerson = new Person("Martin", 27);
        var newPerson2 = new Person("Anna", 34);

        string description = newPerson.GetDescription();
        Console.WriteLine(description);

        newPerson.HaveBirthday().UpdateName("Ivar");

        string description2 = newPerson.GetDescription();
        Console.WriteLine(description2);

    }
}
