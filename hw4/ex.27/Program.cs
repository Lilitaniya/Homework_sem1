/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 */
Console.Write("Введите число: ");
string input = Console.ReadLine();
int sum = 0;
for (int i = 0; i < input.Length; i++)
    {
        char digit = input[i];

        if (char.IsDigit(digit))
        {
            int digitValue = digit - '0'; // Преобразуем символ в числовое значение
            sum += digitValue; // Добавляем значение цифры к сумме
        }
    }
Console.WriteLine($"Сумма цифр в введенном числе равна {sum}");
