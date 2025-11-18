using Tyuiu.KlochenokVA.Sprint2.Task4.V26.Lib;

namespace Tyuiu.KlochenokVA.Sprint2.Task4.V26
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
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #26                                                            *");
            Console.WriteLine("* Выполнил: Клоченок Владимир Алексеевич | ИСПб-25-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y     *");
            Console.WriteLine("* с использованием тернарного оператора, где пользователь вводит         *");
            Console.WriteLine("* значение переменных x, y с клавиатуры, если x - 2 < y / 2,             *");
            Console.WriteLine("* то z = (10+2/x^2)^y иначе x^2 - (1/y)                                  *");


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x, y;
            Console.WriteLine("Введите значние X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значние Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
        }
    }
}