
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int [4];
int length = array.Length;
for (int i =0; i < length; i++)
{
    array[i] = new Random().Next(-99,100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int sum1 = 0;
for (int i = 0; i < length; i++)
{
    if (i%2 == 0)
    {
        sum1 = sum1 + array[i];
    }
}
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum1);

