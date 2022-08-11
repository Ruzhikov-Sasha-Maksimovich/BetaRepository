System.Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите второе число: ");
int number3 = int.Parse(Console.ReadLine()!); 
int Diff1_01 = number1 - number2;
int Diff1_02 = number1 - number3;
int Diff2_01 = number2 - number1;
int Diff2_02 = number2 - number3;
int Diff3_01 = number3 - number2;
int Diff3_02 = number3 - number1;
if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"Максимальное число: {number1}. Оно больше второго чила на {Diff1_01}, и больше третьего на {Diff1_02}");
}

else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"Максимальное число: {number2}. Оно больше второго чила на {Diff2_01}, и больше третьего на {Diff2_02}");
}
else if (number3 > number1 && number3 > number2)
{
    Console.WriteLine($"Максимальное число: {number3}. Оно больше второго чила на {Diff3_01}, и меньше третьего на {Diff3_02}");
}