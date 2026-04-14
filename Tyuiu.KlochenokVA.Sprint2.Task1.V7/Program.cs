using Tyuiu.KlochenokVA.Sprint2.Task1.V7.Lib;

DataService ds = new DataService();

int a = 195;
int b = 16;
int c = 14;
int d = 45;

bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);


Console.Title = "Спринт #2 | Выполнил: Клоченок В. А. | ИСПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Операции сравнения                                 *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Клоченок Владимир Алексеевич | ИСПб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);
Console.WriteLine("d = " + d);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i< 6; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();