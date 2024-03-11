using System;

class AnonymousClass
{
    static void Main(string[] args)
    {
        var presenter = new { Name = "박용준", Age = 45, Topic = "C#" };
        Console.WriteLine($"{presenter.Name}, {presenter.Age}, {presenter.Topic} ");
    }
}