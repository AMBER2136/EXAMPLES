//ВЫВОДИТ ПОСЛЕДНЮЮ ЦИФРУ ВВЕДЕННОГО ЧИСЛА

Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ ТРЕХЗНАЧНОЕ ЧИСЛО");
int x = Convert.ToInt32(Console.ReadLine());
int y = x%10;
Console.WriteLine(y);