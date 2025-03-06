Console.Clear();
Console.Write("Введите число N:");
int N =int.Parse(Console.ReadLine());
int[] arr = new int[N];
for (int i = 0; i < N; i++)
{
    Console.Write($"Введите {i + 1}-й элемент массива: ");
            arr[i] = int.Parse(Console.ReadLine());
}
 bool allPositiveNumbers = true;
        foreach (var number in arr)
        {
            if (number <= 0)
            {
                allPositiveNumbers = false;
                break;
            }
        }

        if (allPositiveNumbers)
        {
            Console.WriteLine("Все элементы массива больше нуля.");
        }
        else
        {
            Console.WriteLine("Есть элементы массива, которые меньше или равны нулю.");
        }
  int max = arr[0]; // Предполагаем, что первый элемент — максимальный
        for (int i = 1; i < N; i++) // Проходимся по остальным элементам
        {
            if (arr[i] > max)
            {
                max = arr[i]; // Обновляем значение максимального элемента
            }
        }

        Console.WriteLine("Максимальный элемент массива: " + max);

        // Теперь выведем все элементы, равные максимальному
        Console.WriteLine("Все максимальные элементы массива: ");
        foreach (var item in arr)
        {
            if (item == max)
            {
                Console.Write(item + " "); // Выводим элемент, если он равен максимальному
            }
        }

        Console.WriteLine(); // Печатаем новую строку после вывода всех максимальных элементов