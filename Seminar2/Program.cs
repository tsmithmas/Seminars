// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

// int randomNumber = new Random().Next(10, 100); // Число от 10 до 99 включительно
// Console.WriteLine($"Случайное число из отрезка [10, 99]: {randomNumber}");
// int firstDigit = randomNumber / 10; 
// int secondDigit = randomNumber % 10;

// // Мой пример решения задачи
// // if(firstDigit > secondDigit) 
// // {
// //     Console.WriteLine("Наибольшая цифра: " + firstDigit);
// // }
// // else
// // {
// //     Console.WriteLine("Наибольшая цифра: " + secondDigit);
// // }

// int max = firstDigit; // Пусть ( можем ошибаться) первая цифра в числе - максимальная 
// if(secondDigit > max) // Если вторая цифра больше максимума,
// {
//     max = secondDigit; // то максимум - вторая цифра 
// }

// // Console.WriteLine("Максимальная цифра в числе: " + randomNumber + " - это: " + max); // Конкатенация
// Console.WriteLine($"Максимальная цифра в этом числе: {max}"); // Интерполяция

// 11. Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Console.Write($"Введите число в отрезке [100, 999]");
// int randomNumber = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное трехзначное число: {randomNumber}");
// int firstDigit = randomNumber / 100;
// int thirdDigit = randomNumber % 10;
// int result = firstDigit * 10 + thirdDigit;
// Console.WriteLine($"Результат: {result}");

// int randomNumber = new Random().Next(100, 1000);
// int result = (randomNumber / 100) * 10 + randomNumber % 10;
// Console.WriteLine($"Случайное трехзначное число: {randomNumber} -> {result}");

// 12. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.Write("Введите первое число: ");
// int firstDigit = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondDigit = Convert.ToInt32(Console.ReadLine());

// if(firstDigit % secondDigit == 0)
// {
//     Console.WriteLine($"Число {secondDigit} кратно числу {firstDigit}");
// }
// else 
// {
//     Console.WriteLine($"Число {secondDigit} не кратно числу {firstDigit}");
//     Console.WriteLine($"Остаток от деления числа {firstDigit} на {secondDigit}: {firstDigit % secondDigit}");
// }

// {                                                          Это другой варинат решения с добавлением посредниковой переменной
//     int Remains = firstDigit % secondDigit;
//     Console.WriteLine($"Число {secondDigit} не кратно числу {firstDigit}");
//     Console.WriteLine($"Остаток: {Remains}");
// }

// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());

if (firstDigit % 7 == 0 && firstDigit % 23 == 0)
{
    Console.WriteLine($"Число {firstDigit} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {firstDigit} не делится на 7 и 23 без остатка");
}