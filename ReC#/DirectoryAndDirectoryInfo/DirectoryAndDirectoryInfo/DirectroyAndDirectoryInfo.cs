using System;
using System.IO;

class DirectoryAndDirectoryInfo
{
    static void Main(string[] args)
    {
        string dir = "C:\\";
        //[1] Direcotry 클래스
        if (Directory.Exists(dir))
        {
            Console.WriteLine("[1] C 드라이브의 모든 폴더 목록 출력");
            foreach (string folder in Directory.GetDirectories(dir))
            {
                Console.WriteLine($"{folder}");
            }
        }

        //[2] DirectoryInfo 클래스
        DirectoryInfo di = new DirectoryInfo(dir + "Temp\\");
        if (di.Exists)
        {
            Console.WriteLine("[2] C 드라이브 Temp 폴더의 모든 파일 목록 출력");
            foreach (var file in di.GetFiles())
            {
                Console.WriteLine($"{file}");
            }
        }
    }
}