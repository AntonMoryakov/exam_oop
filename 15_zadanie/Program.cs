using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

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

        // Расчет минимального, максимального и среднего времени выполнения метода
        long minTime = long.MaxValue;
        long maxTime = long.MinValue;
        long total = 0;

        foreach (var task in tasks)
        {
            long time = task.Result;
            minTime = Math.Min(minTime, time);
            maxTime = Math.Max(maxTime, time);
            total += time;
        }

        double averageTime = (double)total / tasks.Length;

        // Вывод результатов
        Console.WriteLine($"Минимальное время выполнения метода: {minTime} мс");
        Console.WriteLine($"Максимальное время выполнения метода: {maxTime} мс");
        Console.WriteLine($"Среднее время выполнения метода: {averageTime} мс");
    }

    // Метод для подсчета количества элементов, равных Х, в массиве
    static long CountOccurrences(int[] array, int X)
    {
        long count = 0;
        foreach (var num in array)
        {
            if (num == X)
            {
                count++;
            }
        }
        return count;
    }
}
