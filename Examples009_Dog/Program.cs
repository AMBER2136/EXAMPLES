double distance = 10000;
double speedFirst = 2;
double speedSecond = 1;
double speedDog = 5;
string friend = first;
double timef = distance/(speedFirst + speedDog);
double times = distance/(speedSecond + speedDog);
distance = distance - timef * (speedFerst + speedSecond);
distance = distance - timef * (speedSecond + speedSecond);
count=0;

while(distance < 10)
{
    if (friend = first)
    {
        time = distance / (speedDog + SpeedSecond);
        distance = distance - time * (speedFerst + speedSecond);
        friend = second;
    }
    else
    {
        time = distance / (speedDog + SpeedFirst);
        distance = distance - time * (speedFerst + speedSecond);
        friend = first;
    }
    count+=1; 
}
Console.PrintLine(count);
