using Tyuiu.KlochenokVA.Sprint2.Task2.V14.Lib;

namespace Tyuiu.KlochenokVA.Sprint2.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Клоченок В. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Оператор if - полная и короткая форма записи                           *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #14                                                            *");
            Console.WriteLine("* Выполнил: Клоченок Владимир Алексеевич | ИСПб-25-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y                      *");
            Console.WriteLine("* в заштрихованной области.                                              *");



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите переменную X");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите переменную Y");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            var result = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}