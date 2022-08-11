System.Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
int Diff1 = number1 - number2;
int Diff2 = number2 - number1;
if (number1 > number2)
{
    Console.WriteLine($"Максимальное число: {number1}. Оно больше второго на {Diff1}");
}

else if (number2 > number1)
{
    Console.WriteLine($"Максимальное число: {number2}. Оно больше первого на {Diff2}");
}