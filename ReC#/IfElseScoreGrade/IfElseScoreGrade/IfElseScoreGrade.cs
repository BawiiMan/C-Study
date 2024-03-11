﻿using System;

class IfElseScoreGrade
{
    static void Main(string[] args)
    {
        Console.Write("점수 : ");
        int score = Convert.ToInt32(Console.ReadLine());
        string grade = "";

        if (score >= 90)
        {
            grade = "금메달";
        }
        else
        {
            if (score >= 80)
            {
                grade = "은메달";
            }
            else
            {
                if (score >= 70)
                {
                    grade = "동메달";
                }
            }
        }
        Console.WriteLine($"{grade}을 수상했습니다.");
    }
}