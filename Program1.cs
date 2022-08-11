System.Console.WriteLine("Введите число: ");
int Chislo = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Ваше число: {Chislo}");
if(Chislo % 2 == 0)
{
    Console.WriteLine("Число чётное.");
}
else if(Chislo %2 == 1)
{
    Console.WriteLine("Число нечётное.");
}
