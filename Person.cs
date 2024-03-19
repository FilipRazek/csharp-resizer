namespace sample1;

using Newtonsoft.Json;

class Person(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;


    public string Hello(bool isLowercase)
    {
        string message = $"hello {Name}, you are {Age}";
        return isLowercase ? message.ToLower() : message.ToUpper();
    }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
