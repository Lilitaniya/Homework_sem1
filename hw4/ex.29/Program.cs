/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 */
  Console.WriteLine("Введите элементы массива через запятую:");
string[] userArray = Console.ReadLine().Split(',');

    if (userArray.Length == 0)
    {
        Console.WriteLine("Массив пуст.");
    }
    else
    {
    // Ограничиваем количество случайных чисел до восьми
    int numRandomNumbers = Math.Min(8, userArray.Length);

    // Генерация случайных индексов
    Random random = new Random();
    int[] randomIndices = Enumerable.Range(0, userArray.Length).OrderBy(i => random.Next()).Take(numRandomNumbers).ToArray();

    // Выбор случайных чисел из массива и вывод на экран
    string[] randomNumbers = randomIndices.Select(i => userArray[i]).ToArray();

    // Вывод рандомных чисел через запятую
    Console.WriteLine(string.Join(", ", randomNumbers));
    }