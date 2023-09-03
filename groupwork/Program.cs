// Задача 1. Программа, показывающая является ли одно число квадратом другого

// Console.Write("Введите число а = ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите число b = ");
// int b = int.Parse(Console.ReadLine());

// if (a == (b * b))
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }

// Задача 2. В зависимости от дня недели выдавать его название

/* Console.WriteLine("Введите день недели: ");
string num = Console.ReadLine();
switch (num)
{
    case "1":
    Console.WriteLine("Понедельник");
    break;
    case "2":
    Console.WriteLine("Вторник");
    break;
    case "3":
    Console.WriteLine("Среда");
    break;
    case "4":
    Console.WriteLine("Четверг");
    break;
    case "5":
    Console.WriteLine("Пятница");
    break;
    case "6":
    Console.WriteLine("Суббота");
    break;
    case "7":
    Console.WriteLine("Воскресенье");
    break;
    default:
    Console.WriteLine("Нет такого дня недели");
    break;
} */

// Задача 3.

/* Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
for (int first_number =-number; first_number <= number; first_number++)
{
    Console.Write(first_number+" ");
} */

// Задача 4. 

/* Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int last_digit = number % 10;
Console.WriteLine(last_digit); */

// Или так
/* Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;
if (len == 3)
{
    Console.WriteLine(number[2]);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
} */