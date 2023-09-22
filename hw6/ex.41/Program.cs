/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Write("Введите числа, разделяя их запятой: ");
string input = Console.ReadLine();
string[] numberStrings = input.Split(','); 
int count = 0; 
    foreach (string numberStr in numberStrings)
    {
        if (double.TryParse(numberStr, out double number) && number > 0)
        {
            count++;
        }
    }
Console.WriteLine($"Из введенных чисел больше 0: {count}");