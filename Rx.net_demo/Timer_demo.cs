﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net_demo
{
    class Timer_demo
    {
        static void Main(string[] args)
        {
            var timer = Observable.Timer(TimeSpan.FromSeconds(5));
            timer.Subscribe(
            Console.WriteLine,
            () => Console.WriteLine("completed"));
            Console.ReadLine();
        }
    }
}
