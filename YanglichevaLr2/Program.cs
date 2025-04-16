using System;

class Program
{
    static void Main()
    {
        int smallNumber = 58;
        int bigNumber = 175;
        int reactTemp = 700;
        int Counter = 0;

        int[] MyValues = { 10, 12, 14, 16, 18 };

        foreach (int value in MyValues)
        {
            if (value > smallNumber && value < bigNumber && reactTemp > 600)
            {
                Counter++;
            }
        }

        Console.WriteLine($"Количество подходящих значений: {Counter}");

        Counter = 8;
        Console.WriteLine($"Новое значение Counter: {Counter}");

        if (Counter > 5)
        {
            Console.WriteLine("В реакторе достаточное количество параметров.");
        }
        else
        {
            Console.WriteLine("Недостаточное количество параметров!");
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
