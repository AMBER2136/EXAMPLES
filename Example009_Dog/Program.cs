double distance = 10000;
double speedFirst = 2;
double speedSecond = 1;
double speedDog = 5;
double time;
int count = 0;
string friend = "first";


while(distance < 10)
{
    if (friend == "first")
    {
        time = distance / (speedDog + speedSecond);
        distance = distance - time * (speedFirst + speedSecond);
        friend = "second";
        count=count+1;
    }
    if (friend == "second")
    {
        time = distance / (speedDog + speedFirst);
        distance = distance - time * (speedFirst + speedSecond);
        friend = "first";
        count=count+1;
    }
count=count+1;
}
Console.WriteLine(count);

