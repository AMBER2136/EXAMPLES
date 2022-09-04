int Max(int arg1, int arg2, int arg3)
{
    int bobo = arg1;
    if (arg2 > bobo) bobo = arg2;
    if (arg3 > bobo) bobo = arg3;
    return bobo;
}
int a1 = 7;
int b1 = 9;
int c1 = 77;

int a2 = 1;
int b2 = 92;
int c2 = 71;

int a3 = 75;
int b3 = 966;
int c3 = 5;

/*int bobo1 = Max(a1, b1, c1);
int bobo2 = Max(a2, b2, c2);
int bobo3 = Max(a3, b3, c3);
int champ = Max(bobo1, bobo2, bobo3);
Console.WriteLine($"НАИБОЛЬШЕЕ ЧИСЛО {champ}");*/
int champ = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine($"НАИБОЛЬШЕЕ ЧИСЛО {champ}");

//int max = a1;
//if (b1 > max)
//   max = b1;
//if (c1 > max)
//   max = c1;

//if (a2 > max) max = a2;
//if (b2 > max) max = b2;
//if (c2 > max) max = c2;

//if (a3 > max) max = a3;
/*if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine($"МАКСИМАЛЬНОЕ ЧИСЛО РАВНО  {max}");*/
