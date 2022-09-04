
//Заполнение массива случайными числами.
// int[] array = new int[10];
// //int sise = array.Length;
// FillArray(array);
// void FillArray(int[] collection)
// {

//     int sise = collection.Length;
//     int index = 0;
//     while (index < sise)
//     {
//     collection[index] = new Random().Next(1, 10);
//     index++;
//     }
// }
// Console.WriteLine(array[5]);


// int q = new Random().Next(1, 7);
// Console.WriteLine(q);


// Распечатать массив

void PrintArray(int[] collection)
{
    int x = 0;
    int size = collection.Length;
    while (x < size)
    {
        Console.Write($"{collection[x]}  ");
        x++;
    }
}
int[] array = new int[] { 8, 2, 5, 346, 32, 17, 1573 };
PrintArray(array);

