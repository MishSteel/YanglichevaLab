using System;

public class Car
{
    // Поля класса
    public int yearBuilt;           // Год выпуска
    public double maximumSpeed;     // Максимальная скорость

    // Метод для вычисления возраста машины
    public int Age(int currentYear)
    {
        int age = currentYear - yearBuilt;
        return age;
    }

    // Метод для вычисления расстояния, пройденного автомобилем
    public double Distance(double initialSpeed, double time)
    {
        return (initialSpeed + maximumSpeed) / 2 * time;
    }
}

class RedCar
{
    public static void Main()
    {
        Console.WriteLine("Создание объекта типа Car и присвоение его адреса ссылке redPorsche\n");

        // Создание объекта
        Car redPorsche = new Car();

        // Присвоение значений
        redPorsche.yearBuilt = 2009;
        redPorsche.maximumSpeed = 285;

        // Вызов метода Age
        int age = redPorsche.Age(2025);
        Console.WriteLine("redPorsche имеет возраст " + age + " лет.");

        // Вызов метода Distance
        double distance = redPorsche.Distance(31, 0.23);
        Console.WriteLine("redPorsche проехал " + distance + " миль.");

        Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
        Console.ReadKey();
    }
}
