﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] array = new int [4];
int length = array.Length;
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int count = 0;
for (int i = 0; i < length; i++)
{
    if (array[i]%2 == 0);
}
     {
        count++;
     }

 Console.WriteLine("Количество чётных чисел = : " + count);
