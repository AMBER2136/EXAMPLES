/*int a = new Random().Next(100,999);
int b = a%10; 
int c = a/100;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine($"{c}{b}");*/

/*
Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ ВТОРОЕ ЧИСЛО");
int b = Convert.ToInt32(Console.ReadLine());
int c = a%b;
if (c == 0)
{
    Console.WriteLine("КРАТНО");
}
else
{
    Console.WriteLine($"НЕ КРАТНО {c}");
}*/

/*Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 23;
int c = a % 7;
if (b == 0 & c == 0)
{
    Console.WriteLine("КРАТНО");
}
else
{
    Console.WriteLine("НЕ КРАТНО");
}*/

Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ ВТОРОЕ ЧИСЛО");
int b = Convert.ToInt32(Console.ReadLine());

if ((b == a * a) || (a == b * b))
{
    Console.WriteLine("ЯВЛЯЕТСЯ");
}
else
    Console.WriteLine("НЕ ЯВЛЯЕТСЯ");


/*Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО");
int a = Convert.ToInt32(Console.ReadLine());
Qot(a);
void Qot(int a)
{
int b = a % 23;
int c = a % 7;
if (b == 0 & c == 0)
{
    Console.WriteLine("КРАТНО");
}
else
{
    Console.WriteLine("НЕ КРАТНО");
}
}*/