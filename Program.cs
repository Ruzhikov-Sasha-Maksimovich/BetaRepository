System.Console.WriteLine("Введите число от которого будем считать: ");
int Chislo = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число до которого будем считать: ");
int Count = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Число до которого будем считать: {Count}");
while (Chislo <= Count)
{
    if (Chislo % 2 == 0)
    {
        System.Console.WriteLine(Chislo);
        Chislo = Chislo + 1;
    }
    else
    {
        Chislo = Chislo + 1;
    }
}