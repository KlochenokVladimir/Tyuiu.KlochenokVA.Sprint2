using Tyuiu.KlochenokVA.Sprint2.Task5.V15.Lib;

namespace Tyuiu.KlochenokVA.Sprint2.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Клоченок В. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Оператор switch                                                  *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #15                                                            *");
            Console.WriteLine("* Выполнил: Клоченок Владимир Алексеевич | ИСПб-25-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели      *");
            Console.WriteLine("* (понедельником, вторником, …, субботой или воскресеньем) является k-й  *");
            Console.WriteLine("* день не високосного года, в котором 1 января понедельник.              *");


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int k;
            Console.WriteLine("Введите номер дня: ");
            k = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((k < 1) || (k > 365)) res = "Введено неверное значение!";
            else res = "Это день: " + ds.FindDayName(k);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}