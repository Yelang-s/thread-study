using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 线程
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 使用BeginInvoke
            //Action a = Cal;
            //a.BeginInvoke(null, null);
            //Action<object> action = Cal;
            //action.BeginInvoke(123, null, null);
            //Func<object, int> func = CalRet;
            //func.BeginInvoke(123, ar => {
            //    string data = func.EndInvoke(ar).ToString();
            //    Console.WriteLine($"res:{data} {Thread.CurrentThread.ManagedThreadId} end");

            //}, func);


            // 2. Thread类
            // 不带参数
            //Thread t1 = new Thread(new ThreadStart(Cal));
            //t1.Start();
            // 带参数
            //Thread thread = new Thread(new ParameterizedThreadStart(Cal));
            //thread.Start("thread1");

            // 3. ThreadPool
            //ThreadPool.QueueUserWorkItem(new WaitCallback(Cal),"threadpool1");
            //ThreadPool.QueueUserWorkItem(new WaitCallback(Cal), "threadpool2");
            //ThreadPool.QueueUserWorkItem(new WaitCallback(Cal), "threadpool3");
            //ThreadPool.QueueUserWorkItem(new WaitCallback(Cal), "threadpool4");
            //ThreadPool.QueueUserWorkItem(new WaitCallback(Cal), "threadpool5");
            // 4. Task
            //Task t2 = new Task(Cal);
            //t2.Start();

            //Task.Run(() => Cal());

            //TaskFactory taskFactory = new TaskFactory();
            //taskFactory.StartNew(Cal);

            //Task.Factory.StartNew(() => Cal());

            //Task<int> t = Task.Run(() => CalRet(123));
            //t.Wait();
            //int i = t.Result;

            Console.WriteLine();
            Console.ReadKey();
        }

        static void Cal()
        {
            Console.WriteLine($"线程:{Thread.CurrentThread.ManagedThreadId} running");
            Thread.Sleep(2000);
        }

        static void Cal(object obj)
        {
            string data = obj.ToString();
            Console.WriteLine($"线程:{Thread.CurrentThread.ManagedThreadId} {data} running");
            Thread.Sleep(2000);
        }

        static int CalRet(object obj)
        {
            string data = obj.ToString();
            Console.WriteLine($"线程:{Thread.CurrentThread.ManagedThreadId} {data} running");
            Thread.Sleep(2000);
            return 100;
        }

    }
}
