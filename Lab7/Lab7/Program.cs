using System;
using System.Collections.Generic;

namespace UML_Association_Example
{
    public class Заказ
    {
        public int НомерЗаказа { get; set; }
        public DateTime Дата { get; set; }

        public void Оформить()
        {
            Console.WriteLine("Заказ оформлен.");
        }
    }

    public class Клиент
    {
        public string Имя { get; set; }
        public string Email { get; set; }

        // Ассоциация: Клиент имеет список заказов
        public List<Заказ> Заказы { get; set; } = new List<Заказ>();

        public void Зарегистрироваться()
        {
            Console.WriteLine("Клиент зарегистрирован.");
        }

        public void ДобавитьЗаказ(Заказ заказ)
        {
            Заказы.Add(заказ);
            Console.WriteLine("Заказ добавлен клиенту.");
        }
    }

    class Program
    {
        static void Main()
        {
            Клиент клиент = new Клиент { Имя = "Иван", Email = "ivan@example.com" };
            клиент.Зарегистрироваться();

            Заказ заказ1 = new Заказ { НомерЗаказа = 1001, Дата = DateTime.Now };
            клиент.ДобавитьЗаказ(заказ1);

            заказ1.Оформить();
        }
    }
}

