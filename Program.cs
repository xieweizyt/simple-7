using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace simple_7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 单线程
            {
                //单线程
                //Console.WriteLine("start Main");
                //Do();
                //Console.WriteLine("end Main");
            }
            #endregion

            #region 多线程
            {
                //多线程
                //Console.WriteLine("start Main");
                //Task.Run(() =>
                //{
                //    Do();
                //});
                //Console.WriteLine("end Main");
            }
            #endregion

            #region 父子线程
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
            #endregion

            #region Task.Delay  和 Thread.Sleep()
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
            #endregion

            #region 多线程的应用场景
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
            #endregion

            #region Parallel
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
            #endregion

            #region 多线程的异常处理
            {
                //多线程的异常处理
                //List<Task> tasks = new List<Task>();
                //CancellationTokenSource tokenSource = new CancellationTokenSource();

                //for (int i = 0; i < 20; i++)
                //{
                //    string str = $"task{i}";
                //    tasks.Add(Task.Run(() =>
                //    {
                //        tokenSource.Token.ThrowIfCancellationRequested();

                //        Console.WriteLine($"线程ID --- {Thread.CurrentThread.ManagedThreadId.ToString("00")}开始了  task={str}");
                //        if (str == "task6")
                //        {
                //            tokenSource.Cancel();
                //        }
                //        Thread.Sleep(1000);
                //        Console.WriteLine($"线程ID --- {Thread.CurrentThread.ManagedThreadId.ToString("00")}结束了");
                //    }, tokenSource.Token));
                //}
                //Console.WriteLine("1");
            }
            #endregion

            #region 多线程的安全问题
            {
                List<int> list = new List<int>();
                List<Task> tasks = new List<Task>();
                //for (int i = 0; i < 1000; i++)
                //{
                //    tasks.Add(Task.Run(() =>
                //    {
                //        list.Add(i);
                //    }));
                //}
                //Task.Factory.ContinueWhenAll(tasks.ToArray(), t =>
                //{
                //    //会造成list的数量小于1000  等待也没有效果
                //    Console.WriteLine(list.Count);
                //});

                #region 解决方案1 分块区里
                //List<int> list1 = new List<int>();
                //List<int> list2 = new List<int>();
                //List<int> list3 = new List<int>();
                //int i1 = 300;
                //int i2 = 600;
                //int i3 = 1000;
                //tasks.Add(Task.Run(() =>
                //{
                //    for (int i = 0; i < i1; i++)
                //    {
                //        list1.Add(i);
                //    }
                //}));
                //tasks.Add(Task.Run(() =>
                //{
                //    for (int i = i1; i < i2; i++)
                //    {
                //        list2.Add(i);
                //    }
                //}));
                //tasks.Add(Task.Run(() =>
                //{
                //    for (int i = i2; i < i3; i++)
                //    {
                //        list3.Add(i);
                //    }
                //}));
                //Task.Factory.ContinueWhenAll(tasks.ToArray(), t =>
                //{
                //    //经过分块处理之后 不建议在add使用lock，等同于单线程操作 
                //    list1.AddRange(list2);
                //    list1.AddRange(list3);
                //    Console.WriteLine(list1.Count);
                //});
                #endregion

                #region 解决方案2 使用线程安全对线
                {
                    //BlockingCollection<int> list1 = new BlockingCollection<int>();
                    //for (int i = 0; i < 1000; i++)
                    //{
                    //    tasks.Add(Task.Run(() =>
                    //    {
                    //        list1.Add(i);
                    //    }));
                    //}
                    //Task.Factory.ContinueWhenAll(tasks.ToArray(), t =>
                    //{
                    //    Console.WriteLine(list1.Count);
                    //});
                }
                #endregion

            }
            #endregion

            #region 中间变量
            {
                //会造成i是一致的，因为在启动子线程的时候 不会阻塞主线程  当i足够大时 不会是最大值 是子线程运行时i的值
                //for (int i = 0; i < 500000; i++)
                //{
                //    Task.Run(() =>
                //    {
                //        Console.WriteLine($"i={i},线程ID={Thread.CurrentThread.ManagedThreadId.ToString("00")}");
                //    });
                //}

                //解决
                //for (int i = 0; i < 5; i++)
                //{
                //    int k = i;
                //    Task.Run(() =>
                //    {
                //        Console.WriteLine($"i={k},线程ID={Thread.CurrentThread.ManagedThreadId.ToString("00")}");
                //    });
                //}
            }
            #endregion

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
