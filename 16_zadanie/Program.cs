using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Генерация случайного числа Х
        Random random = new Random();
        int X = random.Next(1001); // Генерируем число от 0 до 1000

        // Создание массива случайной длины
        int arrayLength = random.Next(10000000, 15000001); // Генерируем длину от 10 млн до 15 млн
        int[] array = new int[arrayLength];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1001); // Заполняем массив случайными числами от 0 до 1000
        }

        // Создание и запуск 10 потоков для выполнения метода
        Task<long>[] tasks = new Task<long>[10];
        Stopwatch stopwatch = new Stopwatch();

        for (int i = 0; i < tasks.Length; i++)
        {
            tasks[i] = Task.Run(() =>
            {
                stopwatch.Start();
                long result = CountOccurrences(array, X);
                stopwatch.Stop();
                return stopwatch.ElapsedMilliseconds;
            });
        }

        // Ожидание завершения всех потоков
        Task.WaitAll(tasks);

        // Расчет минимального, максимального и среднего времени ожидания захода в критическую секцию
        long minWaitTime = long.MaxValue;
        long maxWaitTime = long.MinValue;
        long totalWaitTime = 0;
        int waitCount = 0;

        foreach (var task in tasks)
        {
            long time = task.Result;
            totalWaitTime += time;
            if (time > 0)
            {
                minWaitTime = Math.Min(minWaitTime, time);
                maxWaitTime = Math.Max(maxWaitTime, time);
                waitCount++;
            }
        }

        double averageWaitTime = (double)totalWaitTime / waitCount;

        // Вывод результатов
        Console.WriteLine($"Минимальное время ожидания захода в критическую секцию: {minWaitTime} мс");
        Console.WriteLine($"Максимальное время ожидания захода в критическую секцию: {maxWaitTime} мс");
        Console.WriteLine($"Среднее время ожидания захода в критическую секцию: {averageWaitTime} мс");
    }

    // Метод для подсчета количества элементов, равных Х, в массиве
    static long CountOccurrences(int[] array, int X)
    {
        long count = 0;
        foreach (var num in array)
        {
            if (num == X)
            {
                // Входим в критическую секцию, чтобы выполнить увеличение счетчика
                Monitor.Enter(array);
                count++;
                Monitor.Exit(array);
            }
        }
        return count;
    }
}

