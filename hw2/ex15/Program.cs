/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите номер дня недели (1 - понедельник, 2 - вторник, и т.д.): ");
int dayOfWeek = int.Parse(Console.ReadLine());

    if (dayOfWeek >= 1 && dayOfWeek <= 7)
    {
        if (dayOfWeek == 6 || dayOfWeek == 7)
        {
            Console.WriteLine("Это выходной! :)");
        }
        else
        {
            Console.WriteLine("Этот день совсем не выходной :(");
        }
    }
    else
    {
        Console.WriteLine("Введите правильный номер дня недели (1-7).");
    }