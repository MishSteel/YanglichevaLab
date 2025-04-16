using System;

class Processor
{
    // Поля
    private string model;
    private int cores;
    private double frequency;

    // Свойства
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Cores
    {
        get { return cores; }
        set
        {
            if (value > 0)
                cores = value;
            else
                Console.WriteLine("Количество ядер должно быть больше нуля.");
        }
    }

    public double Frequency
    {
        get { return frequency; }
        set
        {
            if (value > 0)
                frequency = value;
            else
                Console.WriteLine("Частота должна быть положительной.");
        }
    }

    // Конструктор по умолчанию
    public Processor()
    {
        model = "Неизвестно";
        cores = 1;
        frequency = 1.0;
    }

    // Конструктор с параметрами
    public Processor(string model, int cores, double frequency)
    {
        this.model = model;
        this.cores = cores;
        this.frequency = frequency;
    }

    // Метод для вывода информации
    public void DisplayInfo()
    {
        Console.WriteLine("Модель процессора: " + model);
        Console.WriteLine("Количество ядер: " + cores);
        Console.WriteLine("Тактовая частота: " + frequency + " ГГц");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Используем конструктор по умолчанию
        Processor proc1 = new Processor();
        proc1.DisplayInfo();

        Console.WriteLine();

        // Используем конструктор с параметрами
        Processor proc2 = new Processor("Intel Core i7", 8, 3.6);
        proc2.DisplayInfo();

        Console.WriteLine();

        // Используем свойства
        Processor proc3 = new Processor();
        proc3.Model = "AMD Ryzen 5";
        proc3.Cores = 6;
        proc3.Frequency = 3.9;
        proc3.DisplayInfo();
    }
}
