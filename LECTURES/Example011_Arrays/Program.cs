
/*int[] massiv = new [] { 4, 6, 7, 11 };
Console.WriteLine(massiv[3]);
int[] array={304,17,27,19};
int[] array1 = new int [5] {1,3,6,7,18};
int a = array[1];
Console.WriteLine(a);
array1[1]=1876;
Console.WriteLine(array1[1]);
int[] array2={1,4,5,7,9};
Console.WriteLine(array2.Length);
Console.WriteLine(array2[^1]); 
Console.WriteLine(array2[array2.Length-3]);*/

/*int[] array = { 2, 34, 56, 313, 77, 84, 49, 28, 7 };
int[] somme = new int[] { 6, 7,3,5,12,2};
int sommelength = somme.Length;


int bobo = Max(Max(array[0], array[1], array[2]),
Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

int Max(int arg1, int arg2, int arg3)
{
    int bobo = arg1;
    if (arg2 > bobo) bobo = arg2;
    if (arg3 > bobo) bobo = arg3;
    return bobo;
}

Console.ForegroundColor=ConsoleColor.Red;
Console.BackgroundColor=ConsoleColor.Yellow;
Console.WriteLine($"{bobo} {sommelength}");
Console.ResetColor();
Console.WriteLine(somme[3]);*/

/*[] array = { 2, 84, 56, 313, 77, 84, 49, 28, 7, 111 };
int sise = array.Length;
int index = sise - 1;
int num = 84;

while (index > 0)
{
    if (array[index] == num)
    {
        Console.WriteLine(index);
        break;
    }
    index--;
}
Console.WriteLine(index);
Console.WriteLine(sise);   */

int[] array = new int[10];
int sise = array.Length;
FillArray(array);
void FillArray(int[] collection)
{
    
    int sise = collection.Length;
    int index = 0;
    while (index < sise)
    {
    collection[index] = new Random().Next(1, 10);
    index++;
    }
}
Console.WriteLine(array[5]);
