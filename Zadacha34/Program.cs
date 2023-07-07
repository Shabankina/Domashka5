// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] mas = new int[4];

void FillArray(int[] mas)
{
    int lenght = mas.Length;
    int index = 0;
    while (index < lenght)
    {
        mas[index] = new Random (). Next (100, 1000);
        index++;
    }
}

void PrintArray(int[] mas)
{
    int count = mas.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine (mas[position]);
        position ++;
    }
}
FillArray (mas);
PrintArray (mas);

int count = 0;
int i = 0;

while (i < mas.Length)
{
    if (mas[i] % 2 == 0)
    {
        count = count + 1;
    }    
    i++;
}
Console.WriteLine (count);