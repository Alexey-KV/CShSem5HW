// Задача 36: Задайте одномерный массив, заполненный случайными
//  числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Enter(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrayRandom(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 100);
    }
    return arr;
}
int size = Enter("Please enter the array length: ");
int[] arr = ArrayRandom(size);
Console.Write($"[{string.Join(", ", arr)}]");
int sum = 0;
for(int i = 1; i < arr.Length; i+=2)
{
    sum += arr[i];
}
Console.WriteLine($" -> {sum}");
