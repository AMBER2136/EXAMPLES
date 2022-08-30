double distance = 10000;
double speedFirst = 2;
double speedSecond = 1;
double speedDog = 5;
double time;
int count = 0;
bool friend = false;

while(distance > 10)
{
    if (friend == true)
    {
        time = distance / (speedDog + speedSecond);
        distance = distance - time * (speedFirst + speedSecond);
              
    }
    if (friend == false)
    {
        time = distance / (speedDog + speedFirst);
        distance = distance - time * (speedFirst + speedSecond);
        
    }
    if (friend==true)
    {   
        friend=false;
    }
    if (friend==false)
    {
        friend=true;
    }     
    count=count+=1;
}
Console.WriteLine(count);

