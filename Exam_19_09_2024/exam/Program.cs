 using System;
 using System.Diagnostics;
 using System.Linq;
 using System.Threading;

class Program
 {
    private static readonly object _lockObject = new object();

    static void Func(int X)
    {
        Random rArrayItems = new Random();
        Random rArraySize = new Random();
        int arraySize = rArraySize.Next(10000000, 15000001);
        int[] array = new int[arraySize];

 
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = rArrayItems.Next(0, 1001);
        }

        Array.Sort(array);

        long[] times = new long[10];
        Parallel.For(0, 10, i =>
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            lock (_lockObject)
            {
                int count = array.Count(value => value == X);
            }
            stopwatch.Stop();
            times[i] = stopwatch.ElapsedMilliseconds;
        });

        long minTime = times.Min();
        long maxTime = times.Max();
        double averageTime = times.Average(); 

        Console.WriteLine($"{X}, \nmin {minTime} ms, max {maxTime} ms, average {averageTime} ms");
     }

     public static void Main(string[] args)
     {
         Random random = new Random();
         int x = random.Next(0, 1001);
         Func(x);
        }
 }
