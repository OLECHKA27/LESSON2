Console.Clear();
Console.Write("Введите число N: ");
int N =int.Parse(Console.ReadLine());
int[] arr = new int[N];
for (int i = 0; i < N; i++)
{
    Console.Write($"Введите {i + 1}-й элемент массива: ");
            arr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Введённый массив:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    
