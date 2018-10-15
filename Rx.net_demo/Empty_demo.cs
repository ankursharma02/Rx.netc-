using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rx.net_demo
{
    class Empty_demo
    {
        public static void Main(string[] args)
        {
            var empty = Observable.Empty<string>();
            //Behaviorally equivalent to
            var subject = new ReplaySubject<string>();
            subject.OnNext("Value");
        //    subject.OnCompleted();
            subject.OnCompleted();
            empty.Subscribe(x => Console.WriteLine(x));
            Console.ReadLine();

        }
    }
}