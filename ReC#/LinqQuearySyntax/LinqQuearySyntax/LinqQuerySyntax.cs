using System;
using System.Collections.Generic;
using System.Linq;

class LinqQuerySyntax
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 2, 1, 4, 5 };

        //[1] 메서드 구문
        IEnumerable<int> methodSyntax = numbers.Where(n => n % 2 == 1).OrderBy(c => c);

        foreach (int n in methodSyntax)
        {
            Console.WriteLine(n);
        }
        
        IEnumerable<int> querySyntax =
            from n in methodSyntax
            where n % 2 == 1
            orderby n
            select n;
        foreach (int n in querySyntax)
        {
            Console.WriteLine(n);
        }
    }
}