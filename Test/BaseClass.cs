// инкапсуляция, полиморфизм, наследование и абстракция

class car{

    public virtual void ride(){

        Console.WriteLine("I am riding class car");
    }

}

class lada : car{
    public override void ride(){

        Console.WriteLine("I am riding class lada");
    }
}

class Program{
    static void Main(){
        Car c = new Car();
        Car l = new lada();

        c.ride();
        l.ride();
    }
}