// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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

int i = 1;
int sum = 0;

while (i < mas.Length)
{
    sum = sum + mas[i];
    i++;
    i++;
}
Console.WriteLine(sum);
