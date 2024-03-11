using static System.Console;

class ElseIf
{
    static void Main(string[] args)
    {
        int score = Convert.ToInt32(Console.ReadLine());

        if (score >= 90)
        {
            WriteLine("A");
        }
        else if (score >= 80)
        {
            WriteLine("B");
        }
        else if (score >= 70)
        {
            WriteLine("C");
        }
        else if (score >= 60)
        {
            WriteLine("D");
        }
        else
        {
            WriteLine("F");
        }

    }
}