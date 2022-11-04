// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[]GetRandomArray(int size , int begin, int last)
{
    int[] arr = new int[size];
   Random random= new Random();
    for (int i = 0; i < size; i++)
    {
    arr[i]= random.Next(begin, last+1);
   }
   return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}
int[] array = GetRandomArray(8, 0, 100);
 PrintArray(array);
