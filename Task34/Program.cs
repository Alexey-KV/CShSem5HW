// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Enter(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int[] ArrayRandom(int Leng)
{
    int[] array = new int[Leng];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
int Leng = Enter("Please enter the array length: ");
int[] array = ArrayRandom(Leng);
Console.Write($"[{string.Join(", ", array)}]");
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i]%2==0)
        count++;
}
Console.WriteLine($" -> {count}");