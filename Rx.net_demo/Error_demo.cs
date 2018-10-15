using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net_demo
{
    class Error_demo
    {
        static void Main(string[] args)
        {
            var throws = Observable.Throw<string>(new Exception());
            //Behaviorally equivalent to
            var subject = new ReplaySubject<string>();
            subject.OnError(new Exception());
            throws.Subscribe(x=>Console.WriteLine(x)); 

            Console.ReadLine();
        }
    }
}
