using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net_demo
{
    class Program
    {
        static Action<int> Changed;
        static Subject<int> Changed2 = new Subject<int>();
        static void Main(string[] args)
        {
            var v=Changed2.Subscribe(x=>
                {
                    Console.WriteLine(x);
                    
                });
            Changed2.OnNext(42);
            Changed2.OnNext(2);
            Changed2.OnNext(4);
            v.Dispose();
            Changed2.OnNext(1313);
            Console.ReadLine();
        }
    }
}
