Console.Clear();
int N =10;
int[] arr = new int[N];
for (int i = 0; i < N; i++)
{
    Console.Write($"Введите {i + 1}-й элемент массива: ");
            arr[i] = int.Parse(Console.ReadLine());
}
 bool foundEvenNumber = false;
Console.WriteLine("Четные числа в составе массива:");
        foreach (var item in arr)
        {
             if (item % 2 == 0) // Проверяем, является ли число четным
            {
                Console.Write(item + " ");
             foundEvenNumber = true;
            }
        }
if (!foundEvenNumber)
        {
            Console.WriteLine("Нет четных чисел в массиве.");
        }

        Console.WriteLine(); // Переход на новую строку после вывода всех четных чисел
   