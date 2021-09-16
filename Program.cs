using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace simple_7
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //单线程
                //Console.WriteLine("start Main");
                //Do();
                //Console.WriteLine("end Main");
            }

            {
                //多线程
                //Console.WriteLine("start Main");
                //Task.Run(() =>
                //{
                //    Do();
                //});
                //Console.WriteLine("end Main");
            }

            {
                //父子线程
                //Task.Run(() =>
                //{
                //    Console.WriteLine("start task");
                //    Task.Run(() =>
                //    {
                //        Console.WriteLine("start task1");
                //        Thread.Sleep(1000);
                //        Console.WriteLine("end task1");
                //    });
                //    Task.Run(() =>
                //    {
                //        Console.WriteLine("start task2");
                //        Thread.Sleep(1000);
                //        Console.WriteLine("end task2");
                //    });

                //    Console.WriteLine("end task");
                //});
            }

            {
                //Task.Delay  和 Thread.Sleep()
                //TaskFactory task = new TaskFactory();
                //task.StartNew(() =>
                //{
                //    Thread.Sleep(2000);
                //    Console.WriteLine("1");
                //});
                ////Task.Delay(500);
                //Thread.Sleep(500);
                //Console.WriteLine("2");
            }

            {
                //多线程的应用场景
                //Console.WriteLine("1");
                //Thread.Sleep(1000);
                //Console.WriteLine("2");
                //Thread.Sleep(1000);
                //Console.WriteLine("3");
                //Thread.Sleep(1000);
                //Console.WriteLine("4");
                //Thread.Sleep(1000);
                //Console.WriteLine("完成，开始多线程");

                //TaskFactory task = new TaskFactory();
                //List<Task> tasks = new List<Task>();
                //tasks.Add(task.StartNew(t =>
                //{
                //    Console.WriteLine("start task1");
                //    Thread.Sleep(1000);
                //    Console.WriteLine("end task1");
                //}, "task1"));
                //tasks.Add(task.StartNew(t =>
                //{
                //    Console.WriteLine("start task2");
                //    Thread.Sleep(1100);
                //    Console.WriteLine("end task2");
                //}, "task2"));
                //tasks.Add(task.StartNew(t =>
                //{
                //    Console.WriteLine("start task3");
                //    Thread.Sleep(1200);
                //    Console.WriteLine("end task3");
                //}, "task2"));
                
                //task.ContinueWhenAny(tasks.ToArray(), t =>
                //{
                //    Console.WriteLine($"{t.AsyncState}完成了一个");
                //});

                //task.ContinueWhenAll(tasks.ToArray(), t =>
                //{
                //    Console.WriteLine("全部完成了");
                //});

            }

           
            {
                //Parallel
                //ParallelOptions parallelOptions = new ParallelOptions();
                //parallelOptions.MaxDegreeOfParallelism = 2;
                //List<int> list = new List<int>() { 1,2,3,4,5 }
                //    ;
                //Parallel.ForEach(list, parallelOptions, t =>
                //{
                //    Console.WriteLine($"线程id{Thread.CurrentThread.ManagedThreadId.ToString("00")}");
                //});
            }
            Console.ReadLine();
        }

        static void Do()
        {
            Console.WriteLine("start do");
            Thread.Sleep(1000);
            Console.WriteLine("end do");
        }
    }
}
