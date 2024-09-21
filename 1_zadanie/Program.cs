// 1.	Создать консольное консольное приложение, в котором объявить класс, 
// содержащий конструктор, принимающий 2 параметра (целочисленный и строковый). 
// Значения передаваемых в конструктор параметров записать в автоматически реализуемые свойства. 
// Создать массив элементов созданного класса, размерность массива ввести с клавиатуры. 
// Заполнить массив произвольными значениями (в автоматическом режиме) и вывести на консоль значения элементов массива. 

// using System;

// class Test{
//     public int Num {get;set;}
//     public string Str{get; set;}

//     public Test(int n, string s){
//         Num = n;
//         Str = s;
//     }
// }

// class Program{
//     static void Main(string[] args){
//         Console.WriteLine("Enter number: ");
//         int size = int.Parse(Console.ReadLine());

//         Test[] arr = new Test[size];
//         Random random = new Random();
//         for(int i = 0; i < size; i++){
//             int randomNumber = random.Next(1, 101); // случайное число от 1 до 100
//             string randomText = "Текст_" + randomNumber; // произвольная строка
//             arr[i] = new Test(randomNumber, randomText);
//         }
//         Console.WriteLine("\nЭлементы массива:");
//         for (int i = 0; i < arr.Length; i++)
//             {
//                 Console.WriteLine($"Элемент {i + 1}: Число = {arr[i].Num}, Текст = {arr[i].Str}");
//             }
//     }
// }

// 1.	Создать консольное консольное приложение, в котором объявить класс, 
// содержащий конструктор, принимающий 2 параметра (целочисленный и строковый). 
// Значения передаваемых в конструктор параметров записать в автоматически реализуемые свойства. 
// Создать массив элементов созданного класса, размерность массива ввести с клавиатуры. 
// Заполнить массив произвольными значениями (в автоматическом режиме) и вывести на консоль значения элементов массива. 
using System;

class Test
{
    // Автоматически реализуемые свойства с доступом public
    public int Num { get; set; }
    public string Str { get; set; }

    // Конструктор
    public Test(int n, string s)
    {
        Num = n;
        Str = s;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size: ");
        int size = int.Parse(Console.ReadLine());
        Test[] arr = new Test[size];

        Random rand = new Random();
        for (int i = 0; i < size; i++)
        {
            int randNum = rand.Next(0, 1000);
            string randText = "Text_" + randNum;
            arr[i] = new Test(randNum, randText);
        }

        // Вывод элементов массива
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Element {i + 1}: Num = {arr[i].Num}, Text = {arr[i].Str}");
        }
    }
}
