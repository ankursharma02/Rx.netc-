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
    class Return_demo
    {
        public static void Main(string[] args)
        {
            var singleValue = Observable.Return<string>("Value");
            //which could have also been simulated with a replay subject
            var subject = new ReplaySubject<string>();
            subject.OnNext("Value");
            subject.OnCompleted();
            singleValue.Subscribe(x=>Console.WriteLine(x));
            Console.ReadLine();

        }
    }
}