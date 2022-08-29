Console.WriteLine("ВВЕДИТЕ ВАШЕ ИМЯ");
string username = Console.ReadLine();
if(username.ToLower() == "михаил")
{
    Console.WriteLine("КАК Я РАД ВАМ, МИХАИЛ!");    
}   
else
{
    Console.Write("ЗДРАВСТВУЙТЕ ");
    Console.Write(username);
}
