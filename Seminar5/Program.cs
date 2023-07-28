// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// int size = 12;
// int[] array = new int[size];         
// int sumNegative = 0;
// int sumPositive = 0;
// int i = 0;

// for (i = 0; i < array.Length; i++)                         
// {
//     array[i] = new Random().Next(-9, 10);
//     if (array[i] > 0)
//     {
//         sumPositive = sumPositive + array[i];
//     }
//     else 
//     {
//         sumNegative = sumNegative + array[i];
//     }                             
// }                                                                    
// Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
// Console.WriteLine($"Cумма положительных чисел массива: {sumPositive}");
// Console.WriteLine($"Cумма отрицательных чисел массива: {sumNegative}");

// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int size = 12;
int[] array = new int[size];         
int sumNegative = 0;
int sumPositive = 0;
int i = 0;

for (i = 0; i < array.Length; i++)                         
{
    array[i] = new Random().Next(-9, 10);
    if (array[i] > 0)
    {
        sumPositive = sumPositive + array[i];
    }
    else 
    {
        sumNegative = sumNegative + array[i];
    }                             
}                                                                    
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
Console.WriteLine($"Cумма положительных чисел массива: {sumPositive}");
Console.WriteLine($"Cумма отрицательных чисел массива: {sumNegative}");