using Tyuiu.KlochenokVA.Sprint2.Task3.V11.Lib;

namespace Tyuiu.KlochenokVA.Sprint2.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Клоченок В. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: вложенные операторы if - else                                    *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #11                                                            *");
            Console.WriteLine("* Выполнил: Клоченок Владимир Алексеевич | ИСПб-25-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y     *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит   *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до   *");
            Console.WriteLine("* трех знаков после запятой;                                             *");


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x;
            Console.WriteLine("Введите значение переменной X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            var res = ds.Calculate(x);
            Console.WriteLine(Math.Round(res, 3));
            Console.ReadKey();
        }
    }
}