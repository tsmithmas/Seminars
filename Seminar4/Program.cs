// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int start = 1;
// int sum = 0;
// while (start < A)
// {
//     sum = sum + start;
//     start++;
// } 

// Console.WriteLine($"Сумма чисел: {sum}");

// Задача 26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int count = 0; // Количество чисел 
// int copyNumber = number; // Копия числа number
// if (number != 0)
// {
//     while (number > 0)
//     {
//         count++; // Обнаружена 1 цифра,  count = count + 1
//         number /= 10; // number = number / 10
//     }
// }
// else
// {
//     count++; // Для 0 будет 1 цифра
// }

// Console.WriteLine($"В числе {copyNumber}: {count} цифр(ы)");

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Введите число: ");
// int finish = Convert.ToInt32(Console.ReadLine());
// int composition = 1;
// int start = 1;

// if (finish > 0)
// {
//     while (start < finish)
//     {
//         start++;
//         composition = composition * start;
//     }
//     Console.WriteLine($"Произведение чисел от 1 до {finish}: {composition}");
// }
// else if (finish == 0)
// {
//     Console.WriteLine($"Произведение чисел от 1 до {finish}: 0");
// }



// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int size = 8;
int[] array = new int[size];                           
for (int i = 0; i < array.Length; i++)                         
{
    array[i] = new Random().Next(2);                             
}                                                                    
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");