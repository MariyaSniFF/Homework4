// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());
int Power = RaiseNumberAtoPowerB (numA);

int RaiseNumberAtoPowerB (int numA)
{
    int Power = numA;

    for (int i = 1; i < numB; i++)
    {
        Power = Power * numA;
    }
    return Power;
}
Console.WriteLine("A в степени B = " + Power);