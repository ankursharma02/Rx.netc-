using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net_demo
{
    class Never_demo
    {
        static void Main(string[] args)
        {
            var never = Observable.Never<string>();
            //similar to a subject without notifications
            var subject = new Subject<string>();
            never.Subscribe(x=>Console.WriteLine(x));
            subject.OnNext("Value");
            subject.OnCompleted();
            Console.ReadLine();
        }
    }
}
