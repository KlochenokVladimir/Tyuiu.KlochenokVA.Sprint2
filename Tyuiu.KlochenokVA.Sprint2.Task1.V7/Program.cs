using Tyuiu.KlochenokVA.Sprint2.Task1.V7.Lib;

namespace Tyuiu.KlochenokVA.Sprint2.Task1.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Клоченок В. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Логические операции                                              *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #7                                                             *");
            Console.WriteLine("* Выполнил: Клоченок Владимир Алексеевич | ИСПб-25-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,        *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз          *");
            Console.WriteLine("* в выражении) и логических операций (|, &, ||, &&, !, ^,                *");
            Console.WriteLine("* последовательность операций не должна нарушаться), а также             *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую                    *");
            Console.WriteLine("* последовательность(массив): (True, False, False, False, True, False),  *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую                    *");
            Console.WriteLine("* при a = 195, b = 16, c = 14, d = 45                                    *");



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int a = 195, b = 16, c = 14, d = 45;
            Console.WriteLine($"a = {a}, b = {b}, c = {c}, d = {d}");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            bool[] result = ds.GetLogicOperations(a, b, c, d);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

        }
    }
}