using System;
namespace BmiCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Внимание! Индекс массы тела следует применять с осторожностью, исключительно для ориентировочной оценки!\n");
            int weight, height;
            int procent = 10000; // Magic Number - для избавления чисел после запятой
            Console.Write("Введите вашу массу:");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш рост:");
            height = Convert.ToInt32(Console.ReadLine());
            float bmi = Convert.ToSingle(Math.Round((weight / Math.Pow(height, 2)) * procent, 2)); // BMI(ИМТ) - body mass index (индекс массы тела).

            Console.Write($"Ваш вес - {weight}кг.\nВаш рост - {height}см.\nВаш ИМТ - {bmi}\n");

            switch (Convert.ToDouble(bmi))
            {
                case <= 16:
                    Console.Write("Выраженный дефицит массы тела!");
                    break;
                case < 18.5:
                    Console.Write("Недостаточная масса тела!");
                    break;
                case < 25:
                    Console.Write("Масса тела в норме!");
                    break;
                case < 30:
                    Console.Write("Предожирение, избыточная масса тела!");
                    break;
                case < 35:
                    Console.Write("Ожирение 1 степени!");
                    break;
                case < 40:
                    Console.Write("Ожирение 2 степени!");
                    break;
                case > 40:
                    Console.Write("Ожирение 3 степени!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
