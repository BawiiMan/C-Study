using System;
using System.IO;

class FileAndFileInfo
{
    static void Main(string[] args)
    {
        string file = "C:\\Temp\\Test.txt";

        //[1] File 클래스: 정적 멤버 제공
        if (File.Exists(file))
        {
            Console.WriteLine("{0}", File.GetCreationTime(file));
            File.Copy(file, "C:\\Temp\\Text2.txt", true);
        }

        FileInfo fi = new FileInfo(file);
        if (fi.Exists)
        {
            Console.WriteLine($"{fi.FullName}");
        }
    }
}