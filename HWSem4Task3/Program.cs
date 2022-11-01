// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] Array = new int[8];

for (int i = 0; i < 8; i++)
{
    Array[i] = new Random().Next(0,9);
    Console.Write(Array[i]);
}
Console.WriteLine();
