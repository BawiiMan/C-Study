using System;
using System.IO;

class StreamWriterWriteLineDemo
{
    static void Main(string[] args)
    {
        string data =
            "안녕하세요.\r\n반갑습니다." + Environment.NewLine + "또 만나요.";
        //[1] StreamWriter 클래스를 사용하여 파일 생성
        StreamWriter sw = new StreamWriter("C:\\Temp\\Test.txt");
        
        //[2] Write() 메서드: 저장
        sw.WriteLine(data);

        //[3] StreamWriter 개체를 생성했으면 반드시 닫기
        sw.Close();

        //[4] 메모리 해제
        sw.Dispose();
    }
}