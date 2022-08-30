Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ ВТОРОЕ ЧИСЛО");
int y = Convert.ToInt32(Console.ReadLine());
if (x==y*y)
{
    Console.WriteLine("ДА, ЯВЛЯЕТСЯ");
}
else
{
    Console.WriteLine("НЕТ, НЕ ЯВЛЯЕТСЯ");
}
