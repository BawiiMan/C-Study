using System;

class Fish
{
    public int Weight { get; set; } = 50;
    public void Feed(int weight) => Weight += weight;

}

class ProeprtyPractice
{
    static void Main(string[] args)
    {
        var fish = new Fish();
        fish.Weight = 10;
        fish.Feed(15);
        Console.WriteLine(fish.Weight);
    }
}