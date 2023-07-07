// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[]  array = {3.22, 4.2, 1.15, 77.15, 65.2};

void PrintArray (double[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(array[i]);
    }
    }
PrintArray (array);

double min = 0;
double max = 0;
double i = 0;

while (i < array.Length)
{
    if (array[i] < min)
    {
        double min = array[i];
        i++;
        if (array[i] > min)
        {
            double max = array[i];
        i++;
        }
    }

}
Console.Writeline (max - min);