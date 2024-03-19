namespace sample1;

class Program
{
    static void Main(string[] args)
    {
        Person person = new ("John", 25);
        Console.WriteLine(person.Hello(true));
        Console.WriteLine(person);
    }

}
