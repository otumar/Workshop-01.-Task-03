Console.Write("Введите число => ");
string paramString = Console.ReadLine();
int Paramint = int.Parse(paramString);
if (Paramint % 2 == 0)
{
    Console.WriteLine($"{Paramint} = четное");
}
else
{
    Console.WriteLine($"{Paramint} = нечетное");
}