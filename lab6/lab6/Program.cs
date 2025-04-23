using System;
using System.Collections.Generic;

// Абстрактный класс - Технологический процесс
abstract class TechProcess
{
    public string ElementName { get; set; }
    public int Duration { get; set; }

    public TechProcess(string name, int duration)
    {
        ElementName = name;
        Duration = duration;
    }

    public abstract void ShowInfo();
}

// Производный класс - Технологическое оборудование
class Equipment : TechProcess
{
    public string EquipmentType { get; set; }
    public int PowerConsumption { get; set; }

    public Equipment(string name, int duration, string type, int power)
        : base(name, duration)
    {
        EquipmentType = type;
        PowerConsumption = power;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"[Оборудование] {ElementName}, Время: {Duration} мин, Тип: {EquipmentType}, Потребление: {PowerConsumption} Вт");
    }
}

// Производный класс - Технологические операции
class Operation : TechProcess
{
    public string OperationType { get; set; }
    public int RequiredSkillLevel { get; set; }

    public Operation(string name, int duration, string type, int skillLevel)
        : base(name, duration)
    {
        OperationType = type;
        RequiredSkillLevel = skillLevel;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"[Операция] {ElementName}, Время: {Duration} мин, Тип: {OperationType}, Уровень навыка: {RequiredSkillLevel}");
    }
}

// Точка входа
class Program
{
    static void Main(string[] args)
    {
        List<TechProcess> processes = new List<TechProcess>
        {
            new Equipment("Станок ЧПУ", 120, "Фрезерный", 1500),
            new Operation("Сварка", 45, "Ручная", 3)
        };

        foreach (var process in processes)
        {
            process.ShowInfo();
        }

        Console.ReadLine(); // Чтобы окно не закрылось сразу
    }
}


