// 17. Напишите программу, которая принимает на вход координаты точки 
// (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координату по абсциссе: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по ординат: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) // Обязательно, чтобы был x > 0 и y > 0
// {
//     Console.WriteLine("1 четверть");
// }
// else if (x < 0 && y > 0) 
// {
//     Console.WriteLine("2 четверть");
// }
// else if (x < 0 && y < 0) 
// {
//     Console.WriteLine("3 четверть");
// }
// else if (x > 0 && y < 0) 
// {
//     Console.WriteLine("4 четверть");
// }
// else
// {
//     Console.WriteLine("Вы попали в одну из осей");
// }

// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Введите номер четверти: ");
// int Number = Convert.ToInt32(Console.ReadLine());

// if (Number == 1) 
// {
//     Console.WriteLine($"Диапазон возможных координат: x > 0 и y > 0");
// }
// else if (Number == 2) 
// {
//     Console.WriteLine($"Диапазон возможных координат: x < 0 и y > 0");
// }
// else if (Number == 3) 
// {
//     Console.WriteLine($"Диапазон возможных координат: x < 0 и y < 0");
// }
// else if (Number == 4) 
// {
//     Console.WriteLine($"Диапазон возможных координат: x > 0 и y < 0");
// }
// else
// {
//     Console.WriteLine($"Пожалуйста, введите число от 1 до 4");
// }

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// AB = √(x2 - x1)2 + (y2 - y1)2
// Console.Write("Введите координату по оси оХ для первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оY для первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по оси оХ для второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оY для второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);

// Console.WriteLine($"Расстояние: {d}");

// Math.Sqrt(число) => Math.Sqrt(25) = 5 => Sqrt = корень
// Math.Pow(число, степень) => Math.Pow(2,3) => 2 в 3 степени: 2 * 2 * 2 => Pow - степень
// Math.Round(число, количество знаков) => Math.Round(1.12345, 2) => 1.12 - округление


// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// int start = 1;

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int start = 1;

while (start < Number)
{
    Console.Write(Math.Pow(start, 2) + ", "); // start во степень
    start++; // start = start + 1 - инкремент
}
int end = Convert.ToInt32(Math.Pow(Number, 2));
Console.WriteLine($"{end}");