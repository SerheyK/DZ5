//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double[] array = new double [5];
int length = array.Length;
for (int i = 0; i < length; i++)
{
   array[i] = new Random().Next(-100,100);
   Console.Write (array[i] + " ");
}
Console.WriteLine();
double max = array[0];
double min = array[1];
for (int i = 0; i < length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
double result = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + result);