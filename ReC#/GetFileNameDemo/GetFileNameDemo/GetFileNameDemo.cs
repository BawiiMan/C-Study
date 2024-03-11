using System;

class GetFileNameDemo
{
    static void Main(string[] args)
    {
        //아래 전체 경로가 입력되었을 때 파일 이름과 확장자 추출
        //[1]
        string dir = "C\\Website\\RedPlus\\images\\test.gif";
        string fullName = String.Empty;
        string name = "";
        string ext = name;

        //[2] 처리
        //전체 파일 이름: 마지막 \\ 위치 값 + 1한 위치부터 마지막까지 검색
        fullName = dir.Substring(dir.LastIndexOf('\\') + 1);
        name = fullName.Substring(0, fullName.LastIndexOf("."));
        ext = fullName.Substring(fullName.LastIndexOf("."));

        //[3] 출력
        Console.WriteLine($"전체 파일 이름 : {fullName}");
        Console.WriteLine($"순수 파일 이름 : {name}");
        Console.WriteLine($"확장자 : {ext}");
                
    }
}