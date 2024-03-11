using System;

class ArrayStudents
{
    static void Main(string[] args)
    {
        //요소가 3개인 1차원 배열 생성
        int[] students = new int[3];

        //사용자에게 정수 데이터 3개를 입력받아 배열에 저장
        students[0] = Convert.ToInt32(Console.ReadLine());
        students[1] = Convert.ToInt32(Console.ReadLine());
        students[2] = Convert.ToInt32(Console.ReadLine());

        //총점 구하고 출력
        int total = students[0] + students[1] + students[2];
        Console.WriteLine($"총점 : {total}");

    }
}