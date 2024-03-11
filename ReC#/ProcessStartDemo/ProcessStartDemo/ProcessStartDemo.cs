using System.Diagnostics;

namespace DotNet
{
    class ProcessStartDemo
    {
        static void Main(string[] args)
        {
            Process.Start("Notepad.exe");   //메모장 실행
            Process.Start("Explorer.exe", "https://twitch.com");
        }
    }
}