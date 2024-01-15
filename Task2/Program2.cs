using System;

class vehicle
{
    double x;
    double y;
    int price;
    int speed;
    int release;
    public vehicle(double x, double y, int price, int speed, int release)
    {
        this.x = x;
        this.y = y;
        this.price = price;
        this.speed = speed;
        this.release = release;
    }
    public void showinfo()
    {
        Console.WriteLine($"Координаты: ({x};{y})");
        Console.WriteLine($"Цена: {price}");
        Console.WriteLine($"Скорость: {speed}");
        Console.WriteLine($"Год выпуска: {release}");
    }
}
class Plane: vehicle
{
    double height;
    int count;
    public Plane(double x, double y, int price, int speed, int release, double height, int count):base(x,y,price,speed,release)
    {
        this.height = height;
        this.count = count;
    }
    public new void showinfo()
    {
        base.showinfo();
        Console.WriteLine($"Высота: {height}");
        Console.WriteLine($"Кол-во пассажиров: {count}");
    }
}
class Car: vehicle
{
    public Car(double x, double y, int price, int speed, int release) : base(x, y, price, speed, release) { }
    public new void showinfo() { base.showinfo(); }
}
class Ship: vehicle
{
    string port;
    int count;
    public Ship(double x, double y, int price, int speed, int release, int count, string port):base(x, y, price, speed, release)
    {
        this.port = port;
        this.count = count;
    }
    public new void showinfo()
    {
        base.showinfo();
        Console.WriteLine($"Порт: {port}");
        Console.WriteLine($"Кол-во пассажиров: {count}");
    }
}
class Program2
{
    static void Main()
    {
        Car car1 = new(5, 6, 1500000, 230, 2007);
        Ship ship1 = new(4, 3, 70000000, 15, 2009, 150, "Milan");
        Plane plane1 = new(6, 9, 150000000, 600, 1998, 10000, 50);
        car1.showinfo();
        Console.WriteLine();
        ship1.showinfo();
        Console.WriteLine();
        plane1.showinfo();
    }
}