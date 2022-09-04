//ВВОД Х, ВЫВОД ОТ (-Х) ДО (Х).

Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО");
int x = Convert.ToInt32(Console.ReadLine());
int y=x;
int count=0;
if(x>0)
{
while(y>x-x*2)
{
y = x-count;
Console.Write($" {y}");
count++;
}
}
else
{
 while(y<x-x*2)
{
y = x+count;
Console.Write($" {y}");
count++;   
}
}