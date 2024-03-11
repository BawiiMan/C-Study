using System;
using System.Collections.Generic;

class DictionaryGenericClassDemo
{
    static void Main(string[] args)
    {
        IDictionary<string, string> data = new Dictionary<string, string>();
        //var data = new Dictionary<string, string>();

        data.Add("cs", "C#");
        data.Add("aspx", "ASP.NET");

        data.Remove("aspx");
        data["cshtml"] = "ASP.NET MVC";

        /*
        try
        {
            data.Add("cs", "CSharp");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        */
        foreach (KeyValuePair<string, string> item in data)
        {
            Console.WriteLine("{0}은(는) {1}의 확장자입니다.", item.Key, item.Value);
        }

        foreach (var item in data)
        {
            Console.WriteLine($"{item.Key}은(는) {item.Value}의 확장자 입니다.");
        }
    }
}