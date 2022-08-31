Console.WriteLine("ВВЕДИТЕ ЧИСЛО ОТ 1 ДО 7");
int x = Convert.ToInt32(Console.ReadLine());
if(x>7)  
{
    Console.WriteLine("ЧИСЛО СЛИШКОМ ВЕЛИКО, ВВЕДИТЕ ЧИСЛО ОТ 1 до 7");  
}
else if (x==1)
{ 
    Console.WriteLine("ПОНЕДЕЛЬНИК");
}
else if (x==2)
{
     Console.WriteLine("ВТОРНИК");
}
else if (x==3) 
{
    Console.WriteLine("СРЕДА");
}
else if (x==4)
{
     Console.WriteLine("ЧЕТВЕРГ");
}
else if (x==5)
{
     Console.WriteLine("ПЯТНИЦА");
}
else if (x==6)
{
    Console.WriteLine("СУББОТА");
}
else if (x==7)
{
     Console.WriteLine("ВОСКРЕСЕНЬЕ");
}



