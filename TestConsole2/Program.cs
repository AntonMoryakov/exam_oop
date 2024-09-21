//using System.Linq.Expressions;
// // // 17.Создать консольное приложение,
// // //  в котором объявить метод (и запустить его в отдельном потоке (из пула потоков)) 
// // //  внутри которого запустить бесконечный цикл, который выводит
// // //   на консоль сообщение каждый раз, когда пользователь нажимает 
// // //   Enter. Между нажатиями на Enter поток с бесконечным циклом 
// // //   замирает в ожидании действия пользователя. 




// // using System;
// // using System.Threading;

// // class Program
// // {
// //     // Событие для управления потоком
// //     static ManualResetEvent waitForEnter = new ManualResetEvent(false);

// //     static void Main(string[] args)
// //     {
// //         // Запуск метода в отдельном потоке из пула потоков
// //         ThreadPool.QueueUserWorkItem(WaitForUserInput);

// //         Console.WriteLine("Нажмите Enter для вывода сообщения. Для выхода нажмите Ctrl+C.");

// //         // Основной поток будет отслеживать нажатия клавиши Enter
// //         while (true)
// //         {
// //             if (Console.ReadKey(true).Key == ConsoleKey.Enter)
// //             {
// //                 // Уведомляем поток о нажатии Enter
// //                 waitForEnter.Set();
// //             }
// //         }
// //     }

// //     // Метод, который будет работать в отдельном потоке
// //     static void WaitForUserInput(object state)
// //     {
// //         while (true)
// //         {
// //             // Ожидание, пока основная программа не сообщит о нажатии Enter
// //             waitForEnter.WaitOne();

// //             // Выводим сообщение
// //             Console.WriteLine("Пользователь нажал Enter!");

// //             // Сбрасываем событие, чтобы ожидать следующее нажатие
// //             waitForEnter.Reset();
// //         }
// //     }
// // }


// // 9.Создать консольное приложение, в котором объявить 
// // два делегата для хранения ссылок на методы, обладающие следующими сигнатурами:
// // a.void (int, string, bool)
// // b.int (int[], double)
// // Реализовать методы, подходящие, описанным выше 
// // сигнатурам. Сохранить ссылки на данные в описанных делегатах. Вызвать методы используя созданные делегаты.



// public delegate void firstDelegate(int a, string s, bool b);
// public delegate int secondDelegate(int [] array, double d);

// class Program{
//     public static void first(int a, string s, bool b) {
//         Console.WriteLine($"{a}, {s}, {b}");
//     }

//     public static int second(int[] array, double d){
//         Console.WriteLine($"{array}, {d}");
//         return 10;
//     }
//     public static void Main(string[] args){
//         int a = 1;
//         string s = "qwe";
//         bool b = true;
//         int [] array = {1, 2, 3, 4};
//         double d = 2.3;

//         // first(a, s, b);
//         // second(array, d);

//         firstDelegate firstDelegate = first;
//         secondDelegate secondDelegate = second;
//         firstDelegate(a, s, b);
//         secondDelegate(array, d);

//     }
// }




//инкапсуляция


// using System;


// class test{
//     private int age;

//     public test(int age){
//         this.age = age;
//     }
//     public void display(int age){
//         Console.WriteLine(age);
//     }

// }

// class Program{
//     static void Main(string[] args){
//         int testA = 10;
//         test t = new test(testA);
//         t.display(testA);
        
//     }
// }


//наследование

// using System;

// public class Test{
//     public int age{get;set;}
//     public Test(int age){
//         this.age = age;
//     }
// }

// public class Test2 : Test{
//     public string name{get;set;}
//         public Test2(int age, string name): base(age){
//             this.name = name;
//     }
// }

// class Program{
//     public static void Main(string[] args){
//         Test2 test2= new Test2(1, "qwe");
//         test2.age=0;
//         Test test = new Test(1);
//         test.age= 10;
//     }
// }



//полиморфизм

// using System;
// using System.Diagnostics.Contracts;


// public class first{
//     public virtual void func(){
//         Console.WriteLine("qwert");
//     }
// }

// public class second : first{
//     public override void func(){
//         Console.WriteLine("094907r47047");
//     }
// }
// public class third : first{
//     public new void func(){
//         Console.WriteLine("third class");
//     } 
// }

// class Program{
//     public static void Main(string[] args) {
//         first f = new first();
//         first s = new second();
//         f.func();
//         s.func();
//         first t = new third();
//         t.func();
//         third th = (third)t;
//         th.func();
//     }
// }


//Абстракция

// abstract class TestBase{
//     public abstract void Display();
// }


// class Test : TestBase{
//     public override void Display(){
//         Console.WriteLine("qwerty");
//     }
// }

// class Peogram{
//     public static void Main(string[] args){
//         Test t = new Test();
//         t.Display();

//         TestBase testBase = new Test();
//         testBase.Display();
//     }
// }


// int [] obj = new int[3];
// int [] obj2 = {1,2, 3, 4};

// int [,] obj3 = new int[,] {{1,2,3,4},{2,3,5,6}};



// int [][] test = new int[2][];
// test[0] = new int[] {1, 3};
// test[1] = new int[] {1, 3, 4, 5, 6, 7};


// Array.Fill(obj, 1);


// 6.Условные операторы и операторы цикла. Примеры.

// foreach(var element in obj){

// }



// 7.Классы. Определение класса, объявление и инициализация переменных типа класса. Элементы класса. Примеры.

// public class Test{
//     //public int a{get;set;}
//     public virtual void testFunc(){

//     } 

//     private int _b;
//     public int b{
//         get{
//             return _b;
//         }
//         set{
//             _b = value;
//         }
//     }
//     public Test(int b){
//         this.b = b;
//     }
//     ~Test(){

//     }
// }


// class test2 : Test{

//     public sealed override void testFunc(){

//     }
//     public test2(int b) : base(b)
//     {
//     }

//     public void Display(){
//         Test test = new Test(1);
//         test.b = 1;
         
//     }
// }
// 8.Модификаторы передаваемых в методы параметров (in, out, ref). Примеры. 

// 9.Организация наследования в языке программирования C#. Механизмы запрета наследования.

// 10.Специальные методы: конструктор и финализатор. Объявление и вызов. "Наследование" специальных методов.

// 11. Виртуальные элементы класса. Переопределение методов и операторов. Примеры.


// public static Test operator+(Test a, Test b){
//     return a.a + b.b;
// }

// public override string ToString(){
//     return $"{a.a}";
// }

// public interface ITest1 : ITestBase, ITest2{
//     void qwe();
// }
// public interface ITest2{
//     void qwe1();
// }
// public interface ITestBase{
//     void qwe2();
// }

// public class Test : ITest1, ITest2 {
//     public void qwe() {
//         Console.WriteLine("lkjfhilofjhpiouh");
//     }
//     public void qwe1() {
//         Console.WriteLine("lkjfhilofjhpiouh");
//     }
//     public void qwe2() {
//         Console.WriteLine("lkjfhilofjhpiouh");
//     }
// }


// class Program{
//     static void Main(string[] args) {
//         ITestBase test1= new Test();
//         test1.qwe2();
//     }
// }


// 13.Механизм внедрения зависимостей Dependency Injection (DI).

// public interface IService{
//     void display();
// }

// public class Service : IService{
//     public void display() { 
//         Console.WriteLine("'pikofijo'df");
//     }
// }
// public class testClass{
//     private readonly IService _IService;
    
//     public testClass(IService service) {
//         _IService = service;
//     }
//     public void testClassFunc(){
//         _IService.display();
//     }
// }


// class Program{
//     public static void Main(string[] args) {
//         builder.services.AddTransient<IService, Service>();
//         IService service= new Service();
//         testClass testC = new testClass(service);
//         testC.testClassFunc();
//     }
// }


// 14. Универсальные шаблоны/Generic/Обобщения. 
// Определение классов, содержащих универсальные шаблоны, 
// и объявление переменных типов данных классов. Отличия от механизма boxing\unboxing
// 15.Ограничения обобщений и их наследование.

// class Test<T>{

//     public T a{get;set;}

//     public Test(T a){
//         this.a=a;
//     }
// }


// class Program{
//     public static void Main(string[] args){
//         Test<int> test= new Test<int>(10);
//         Test<int> test2= new Test<int>(10);
//         Test<string> test3= new Test<string>("duyhf");
//         test.a=0;
//     }
// }

// Делегаты. Определение, объявление и вызов делегатов. Встроенные делегаты Action\Func\Predicate. Отличия от событий.

// public delegate int TestDelegate(int a);


// class Program{
//     public static int testFunc(int a) { return a; }

//     public static void Main(string[] args) {
//         int a = 10;
//         TestDelegate testDelegate = new TestDelegate(testFunc);
//         Console.WriteLine(testDelegate(a));

//         Action<string> printf = Console.WriteLine;
//         printf("1we");

//         Func<int, int, int> testttt = (int x, int y) =>  x + y;
//         int r = testttt(4, 5);

//         Predicate<int> isTrue = x => x == 4;
//         bool tr = isTrue(a);

//     }
// }



// 17.!!!!!Понятия ковариантности и контрвариантности делегатов. Примеры.



// public delegate Car Machine();
// public delegate void Machine2(Car car);

// public class Car{

// }

// class Audi : Car{
    
// }

// class program{
//     static Car car(){
//         return new Audi();
//     }
//     static void car2(Car car){
        
//     }
//     public static void Main(string[] args){
//         Machine machine= new Machine(car);
//         var item = machine();
//         Console.WriteLine(item);


//         Machine2 machine2= new Machine2(car2);
//         machine2(new Audi());
//         Console.ReadLine();

//     }
// }
// 18.!!!!!События\Event. Определение, объявление и вызов событий. Методы Add и Remove. Отличия от делегатов. 

// public class Test{
//     public delegate void testDelegate(int a);
//     public event testDelegate myEvent{
        
//         add{
//             _myEvent += value;
//         }
//         remove{
//             _myEvent -= value;
//         }
//     }
//     private testDelegate _myEvent;

//     public void func(int a){
//         _myEvent.Invoke(a);
//     }
// }

// class Program{
//     public static void testFunc(int a){
//         Console.WriteLine(a);
//     }
//     public static void Main(string[] args){
//         Test test= new Test();
//         test.myEvent += testFunc;
//         test.func(2);
//     }
// }
using System;

public class Test{
    public static void Main(string[] args){
        Console.WriteLine("");
        for(int i = 0; i < 100; i++){
            Console.WriteLine("" + i);
        }
        int a = 10;
        Console.WriteLine("" + a);
    }
}

// 19.Технологии Object-Relation Mapping (ORM). Технология EF Core. Понятия «контекст» и «миграция»
// 20.!!! Получение, добавление и изменение записей в базе данных используя механизмы EF Core.

// взаимдействие с базой данных осуществляется черезх линку выражений. Из таблиц, которые мы определили в DBSet

// 21.!!!Загрузка связанных сущностей. Eager\Lazy\Explict loading определение и отличия. Понятие каскадного удаления связанных сущностей. 

//Lazy

// public class Student{
//     public int Id { get; set;}
//     public string Name { get; set;}
//     public Decanat decanat{ get; set;}
// }
// class Decanat{

// }

// Datacontext : DbContext{
    
// }

// 26.Конкурентный доступ к данным. Механизмы синхронизации потоков – мьютекс. Пример реализации
// 27.Конкурентный доступ к данным. Механизмы синхронизации потоков – семафор. Пример реализации
// 28.Конкурентный доступ к данным. Механизмы синхронизации потоков – монитор. Пример реализации