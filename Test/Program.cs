// //  Интерфейса. Интерфесные ссылки. Механизм внедрения зависимостей Dependency Injection (DI).

// // interface TestInterface{
// //     void test();
// // }

// // class TestClass : TestInterface{
// //     public void test(){
// //         Console.WriteLine("Hello");
// //     }
// // }

// // class TestClass2 : TestInterface{
// //     public void test(){
// //         Console.WriteLine("Hello, World");
// //     }
// // }

// // class TestService{
// //     private readonly TestInterface _testInt;

// //     public TestService(TestInterface testInt){
// //         _testInt = testInt;
// //     }
// //     public void doWork(){
// //         _testInt.test();
// //     }
// // }

// // class program{
// //     static void Main(){
// //         TestInterface t = new TestClass();
// //         TestService t2 = new TestService(t);
// //         t2.doWork();

// //         t = new TestClass2();
// //         TestService t3 = new TestService(t);
// //         t3.doWork();
// //     }
// // }

// //  Универсальные шаблоны/Generic/Обобщения. 
// //  Определение классов, содержащих универсальные шаблоны, 
// //  и объявление переменных типов данных классов. 
// //  Отличия от механизма boxing\unboxing
// // interface interfaceTest{
// //     void printmes(int a);
// // }
// // class TestGeneric<T> where T : interfaceTest{
// //     public T value{get;set;}

// //     public T printmes(){
// //         return value; 
// //     }
// // }
// // sealed class Test : interfaceTest{
// //     public int val{get;set;}
// //     public void printmes(int value){
// //         Console.WriteLine(value);
// //     }
// // }

// // class Program{
// //     static void Main(){
// //         TestGeneric<Test> testInt = new TestGeneric<Test>();

// //     }
// // }


// // Ограничения обобщений и их наследование.
// //Делегаты. Определение, объявление и вызов делегатов. Встроенные делегаты Action\Func\Predicate. Отличия от событий.

// //class Test{
//     // public delegate void testDelegate();

//     // public void printMes(){
//     //     Console.WriteLine("ya pomirayou");
//     // }
//     // public void printMes2(){
//     //     testDelegate randomName = printMes;
//     //     randomName();
//     // }



// //     delegate void testDelegate();
// //     void printmes(){
// //         Console.WriteLine("qwe");
// //     }

// //     void test2(){
// //         testDelegate ts = printmes;
// //         ts();
// //     }


// //     delegate string stringDelegate(int a);
// //     string stringFunc(int b){
// //         return b.ToString();
// //     }

// //     void testfunc2(){
// //         stringDelegate sd = stringFunc;
// //         int c = 100;
// //         var t = sd(c);
// //     }
// // }
// // public delegate Animal AnimalDelegate();

// // public class Animal { }
// // public class Dog : Animal { }

// // public class Program
// // {
// //     public static Dog GetDog() => new Dog();

// //     public static void Main()
// //     {
// //         AnimalDelegate del = GetDog; // Ковариантность: Dog является производным от Animal
// //         Animal animal = del(); // Возвращает Dog, но можно присвоить переменной типа Animal
// //     }
// // }

// // События\Event. Определение, объявление и вызов событий. Методы Add и Remove. Отличия от делегатов.

// // public delegate void MyEventHandler(string message);

// // public class MyClass
// // {
// //     public event MyEventHandler MyEvent;

// //     public MyClass()
// //     {

// //     }

// //     public void RaiseMyEvent(string message)
// //     {
// //         MyEvent?.Invoke(message);
// //     }

// //     public void AddEventHandler(MyEventHandler handler)
// //     {
// //         MyEvent += handler;
// //     }

// //     public void RemoveEventHandler(MyEventHandler handler)
// //     {
// //         MyEvent -= handler;
// //     }
    
// // }

// // class Program{
// //     static void delegatefunc(string mes){
// //             Console.WriteLine(mes);
// //         }
// //     static void delegatefunc2(string mes){
// //             Console.WriteLine($"_ {mes}");
// //         }
// //     static void Main(){
// //         MyClass mc = new MyClass();
// //         mc.AddEventHandler(delegatefunc);
// //         mc.AddEventHandler(delegatefunc2);
// //         mc.RaiseMyEvent("lkhgpio;ughpijkhb");
// //         // mc.RemoveEventHandler(delegatefunc);
// //                 mc.RaiseMyEvent("lkhgpio;ughpijkhb");

// //     }
// // }


// // Получение, добавление и изменение записей в базе данных используя механизмы EF Core.


// //задания почитать про linq выражения, про отложенное и немедленное выполнение запросов 

// // interface person{
// //     void writeExam();
// // }

// // class student : person{
// //     public void writeExam(){
// //         Console.WriteLine("wikhijfpjh");
// //     }
// // }

// // class servicePerson{
// //     private readonly person p;

// //     public servicePerson(person p){
// //         this.p = p;
// //     }

// //     public void serviceTest(){
// //         p.writeExam();
// //     }
// // }

// // class program{
// //     static void Main(){
// //         person p = new student();
// //         servicePerson sP = new servicePerson(p);

// //         sP.serviceTest();
// //         p.writeExam();
// //     }
// // }


// // Делегаты. Определение, объявление и вызов делегатов. Встроенные делегаты Action\Func\Predicate. Отличия от событий.

// // public delegate void testDelegate(string mes);

// // public class testClass{
// //     public void testFunc(string mes){
// //         Console.WriteLine(mes);
// //     } 
// // }


// // class Program{
// //     static void testFunc(string mes){
// //         Console.WriteLine(mes);
// //     }
    
// //     static void Main(){
// //         testDelegate testDel = new testDelegate(testFunc);
// //         testDel("qwertyu");

// //         testClass tc = new testClass();
// //         testDelegate testDel2 = new testDelegate(tc.testFunc);
// //         testDel2(";kjhfkljhfpo;il");
// //     }
// // }
// //using System;
// // using System.Threading;

// // class Program{
    
// //     static void test(){
// //         //Thread.Sleep(10000);
// //         Console.WriteLine("klhj");
        
// //     }
// //     static void test2(object mes){
// //         //Thread.Sleep(10000);
// //         //Task.Delay(10000).Wait();
// //         Console.WriteLine("klhj");
        
// //     }
// //     static void Main(){
// //         Thread thread = new Thread(test);
// //         Thread thread2 = new Thread(new ParameterizedThreadStart(test2));
// //         thread.Start();
// //         thread2.Start(54);
// //         //thread.Join();
// //         Console.WriteLine("end");


// //         Task t = new Task(test);
// //         t.Start();
// //     }
// // }

// //CPU Bound


// // Конкурентный доступ к данным. Механизмы синхронизации потоков – мьютекс. Пример реализации




// // class Program{
// //     static int a = 0;
// //     static Mutex m = new Mutex();
// //     static Semaphore s = new Semaphore(2, 2);

// //     private object objLock = new object();
// //     static void increment(){
// //         Monitor.Enter(objLock);
// //         try
// //         {
// //             a++;
// //         }
// //         finally{
// //             Monitor.Exit(objLock);
// //         }
// //         lock(objLock){
// //             a++;
// //         }
// //     }
// //     // static void increment(){
// //     //     m.WaitOne();
// //     //     try
// //     //     {
// //     //         a++;
// //     //     }
// //     //     finally{
// //     //         m.ReleaseMutex();
// //     //     }
// //     // }

// //     static void Main(){
// //         Thread thread1 = new Thread(increment);
// //         Thread thread2 = new Thread(increment);

// //         thread1.Start();
        
// //         thread2.Start();

// //         thread1.Join();
// //         thread2.Join();
// //     }
// // }


// // // Базовый класс
// // public class Animal
// // {
// //     public string Name { get; set; }
// //     public int age {get;set;}
    
// //     public void Speak()
// //     {
// //         Console.WriteLine("Animal makes a sound");
// //     }
// // }

// // // Производный класс
// // public class Dog : Animal
// // {
// //     // public void Bark()
// //     // {
// //     //     Console.WriteLine("Dog barks");
// //     // }
// // }

// // class Program
// // {
// //     static void Main()
// //     {
// //         Dog myDog = new Dog();
// //         myDog.Name = "Buddy";
// //         myDog.age = 20;
// //         myDog.Speak(); // Вызов метода базового класса
// //         //myDog.Bark();  // Вызов метода производного класса
// //         Console.WriteLine($"{myDog.Name} {myDog.age}");
// //         Animal an = new Animal();
// //         string nameAnimal = an.Name = "qwerty";
// //         Console.WriteLine(nameAnimal);
// //         an.Speak();
// //         myDog.Speak();
// //     }
// // }
// // public class Animal
// // {
// //     public string name { get; set; }

// //     // Конструктор базового класса
// //     public Animal(string name)
// //     {
// //         this.name = name;
// //         Console.WriteLine("Animal constructor called.");
// //     }
// // }

// // public class Dog : Animal
// // {
// //     public string Breed { get; set; }
// //     public string Name { get; set; }

// //     // Конструктор производного класса с вызовом конструктора базового класса
// //     public Dog(string name, string breed) : base(name)
// //     {
// //         Breed = breed;
// //         Console.WriteLine("Dog constructor called.");
// //     }
// // }

// // class Program
// // {
// //     static void Main()
// //     {
// //         Dog myDog = new Dog("Buddy", "Labrador");
// //         Console.WriteLine(myDog.name);
// //     }
// // }

// // public interface Test{
// //     void testFunc();
// // }

// // public class testClass : Test{
// //     public void testFunc(){
// //         Console.WriteLine("qwkjhgf");
// //     }
// // }

// // class program{
// //     static void Main(){
// //         Test ts = new testClass();
// //         ts.testFunc();
// //     }
// // }


using System;

// Интерфейс сервиса
public interface IMessageService
{
    void SendMessage(string message);
}

// Реализация сервиса
public class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}

// Класс, использующий сервис через внедрение зависимостей
public class Notification
{
    private readonly IMessageService _messageService;

    // Внедрение зависимости через конструктор
    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Notify(string message)
    {
        _messageService.SendMessage(message);
    }
}

class Program
{
    static void Main()
    {
        // Создаем объект сервиса
        IMessageService emailService = new EmailService();

        // Внедряем зависимость в класс Notification через конструктор
        Notification notification = new Notification(emailService);

        // Используем объект
        notification.Notify("Hello, Dependency Injection!"); // Sending email: Hello, Dependency Injection!
    }
}
