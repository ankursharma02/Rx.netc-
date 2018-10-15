using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net_demo
{
    public interface IObservable<out T>
    {
        //Notifies the provider that an observer is to receive notifications.
        IDisposable Subscribe(IObserver<T> observer);
    }
    public interface IObserver<in T>
    {
        //Provides the observer with new data.
        void OnNext(T value);
        //Notifies the observer that the provider has experienced an error condition.
        void OnError(Exception error);
        //Notifies the observer that the provider has finished sending push-based notifications.
        void OnCompleted();
    }
    public class MyConsoleObserver<T> : IObserver<T>
    {
        public void OnNext(T value)
        {
            Console.WriteLine("Received value {0}", value);
        }
        public void OnError(Exception error)
        {
            Console.WriteLine("Sequence faulted with {0}", error);
        }
        public void OnCompleted()
        {
            Console.WriteLine("Sequence terminated");
        }
    }
    public class MySequenceOfNumbers : IObservable<int>
    {
        public IDisposable Subscribe(IObserver<int> observer)
        {
            observer.OnNext(1);
            observer.OnNext(2);
            observer.OnNext(3);
            observer.OnCompleted();
            return Disposable.Empty;
        }
    }
    class KeyValue_demo
    {
        public static void Main(string[] args)
        {
             var numbers = new MySequenceOfNumbers();
            var observer = new MyConsoleObserver<int>();
            numbers.Subscribe(observer);
            Console.ReadLine();
        }
    }
}
