namespace Classes;

class Person
{
    public string Name;

    public int Age;

    public Person()
    {
        Name = "Unknown";

        Age = 0;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"This is {Name}, {Name} is {Age} years old.");
    }

    public Person HaveBirthday()
    {
        Age++;
        return this;
    }

    public void UpdateName(string newName)
    {
        Name = newName;
    }

    public string GetDescription()
    {
        string description = $"Name: {Name}, Age: {Age}";
        return description;
    }
}