﻿using System;
using System.Threading.Tasks;

class AsyncMain
{
    static async Task Main()
    {
        await Task.Delay(1000); //1초

        Console.WriteLine("비동기 메인 메서드");
    }
}