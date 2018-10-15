using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net_demo
{
    class Range
    {
        static void Main(string[] args)
        {
            var range = Observable.Range(22, 15);
            
            range.Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
            
            Console.ReadLine();
        }
    }
}
