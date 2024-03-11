using System;

class AverageAlgorithm
{
    static void Main(string[] args)
    {
        //[1] 입력: n명의 성적
        int[] data = { 90, 65, 78, 50, 95 };
        int sum = 0;    //합계를 담는 그릇
        int count = 0;  //개수 담는 그릇

        //[2] 처리: AVG = SUM / COUNT
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] >= 80 && data[i] <= 95) //주어진 조건
            {
                sum += data[i];
                count++;
            }
        }

        double avg = 0.0f;
        if (sum != 0 && count != 0) //예외 처리
        {
            avg = sum / (double)count;  //AVERAGE
        }

        //[3] 출력
        Console.WriteLine($"80점 이상 95점 이하인 자료 평균 : {avg:0.00}");
    }
}