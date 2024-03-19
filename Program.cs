namespace sample1;

class Program
{
    static void Main(string[] args)
    {
        Person person = new ("John", 25);
        Console.WriteLine(person.Hello(true));
    }

}


class Person(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;


    public string Hello(bool isLowercase)
    {
        string message = $"hello {Name}, you are {Age}";
        return isLowercase ? message.ToLower() : message.ToUpper();
    }

}
