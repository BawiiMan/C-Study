using System;
using System.Net.Http;
using System.Threading.Tasks;

class HttpClientDemo
{
    static async Task Main()
    {
        //[1] HttpClient 개체 생성
        HttpClient httpClient = new HttpClient();

        //[2] GetAsync() 메서드 호출
        HttpResponseMessage httpResponseMessage =
            await httpClient.GetAsync("https://www.microsoft.com/");

        //[3] HTML 가져오기
        string resposeBody = await httpResponseMessage.Content.ReadAsStringAsync();

        //[4] 출력
        Console.WriteLine(resposeBody);
    }
}