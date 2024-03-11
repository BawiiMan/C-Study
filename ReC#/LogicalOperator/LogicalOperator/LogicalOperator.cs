using static System.Console;

class LogicalOperator
{
    static void Main(string[] args)
    {
        var i = 3;
        var j = 5;
        var r = false;

        r = (i == 3) && (j != 3);   //r = true && true => true
        WriteLine(r);

        r = (i != 3) || (j == 3); // r = false || false => false
        WriteLine(r);

        r = (i >= 5);   //r => false
        WriteLine("{0}", !r);    //false -> true

        WriteLine(false && true);   //false
        WriteLine((1 == 1) || (1 != 1));    //true
        WriteLine(!(1 == 1));   //true -> false
    }
}