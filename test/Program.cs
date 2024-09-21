// using System;

// class Person
// {
//     // Поля класса, доступные только внутри класса
//     private string name;
//     private int age;

//     // Конструктор для инициализации полей
//     // public Person(string name, int age)
//     // {
//     //     this.name = name;
//     //     this.age = age;
//     // }
//     public Person(string N, int A)
//     {
//         name = N; age = A;
//     }

//     // Метод для получения имени
//     public string GetName()
//     {
//         return name;
//     }

//     // Метод для установки имени
//     public void SetName(string name)
//     {
//         this.name = name;
//     }

//     // Метод для получения возраста
//     public int GetAge()
//     {
//         return age;
//     }

//     // Метод для установки возраста
//     public void SetAge(int age)
//     {
//         // Пример проверки для возраста
//         if (age > 0)
//         {
//             this.age = age;
//         }
//         else
//         {
//             Console.WriteLine("Возраст должен быть положительным.");
//         }
//     }

//     // Метод для вывода информации о человеке
//     public void DisplayInfo()
//     {
//         Console.WriteLine($"Name: {name}, Age: {age}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Создание объекта Person
//         Person person = new Person("Alice", 30);

//         // Доступ к публичным методам
//         person.DisplayInfo();
        
//         // Изменение имени и возраста через методы
//         person.SetName("Bob");
//         person.SetAge(25);

//         // Вывод измененной информации
//         person.DisplayInfo();
//     }
// }


using System;

// Базовый класс
class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public int GetAge()
    {
        return age;
    }

    public void SetAge(int age)
    {
        if (age > 0)
        {
            this.age = age;
        }
        else
        {
            Console.WriteLine("Возраст должен быть положительным.");
        }
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

// Производный класс
class Student : Person
{
    private string studentId;

    public Student(string name, int age, string studentId)
        : base(name, age) // Вызов конструктора базового класса
    {
        this.studentId = studentId;
    }

    public string GetStudentId()
    {
        return studentId;
    }

    public void SetStudentId(string studentId)
    {
        this.studentId = studentId;
    }

    // Переопределение метода базового класса
    public override void DisplayInfo()
    {
        base.DisplayInfo(); // Вызов метода базового класса
        Console.WriteLine($"Student ID: {studentId}");
    }
}

class Program
{
    static void Main()
    {
        // Создание объекта базового класса
        Person person = new Person("Alice", 30);
        person.DisplayInfo();

        // Создание объекта производного класса
        Student student = new Student("Bob", 22, "S12345");
        student.DisplayInfo();
    }
}
