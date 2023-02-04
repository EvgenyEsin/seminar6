// Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1,  y = k2 * x + b2
// значения b1, k1, b2 и k2 задаются пользователем
// b1 = 2, k1 = 5,   b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Вариант 1.
Console.WriteLine("Введите b1: ");
float b1 = Convert.ToInt32(Console.ReadLine()); // используем переменную float
Console.WriteLine("Введите k1: "); //              чтобы хранить дробные значения
float k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
float b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
float k2 = Convert.ToInt32(Console.ReadLine());

float x = (b2 - b1) / (k1 - k2); // так как оба уравнения равны, выводим значение x
// тут могла быть проверка на деление на 0. Если к1-к2 = 0, то ошибка.
float y = k1 * x + b1; // находим значение y по первому уравнению
Console.Write($"b1 = {b1}, k1 = {k1},  b2 = {b2}, K2 = {k2} -> ({x}; {y})");


// Вариант 2.
string[,] array = { { "b1", "k1" }, { "b2", "k2" } }; // создаем массив для запроса на 
                                                      // введение чисел
float[,] coordin = new float[2, 2];// В этот массив будем запоминать введенные числа
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        // В одном цикле будем выводить на экран запрос и запоминать числа
        Console.WriteLine("Введите " + array[i, j] + ": ");
        coordin[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
float x2 = (coordin[1, 0] - coordin[0, 0]) / (coordin[0, 1] - coordin[1, 1]);
// та же формула, что и в 1 варианте, но в виде индексов элементов массива
float y2 = coordin[0, 1] * x2 + coordin[0, 0];


for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write($"{array[i, j]} = {coordin[i, j]}, ");
    }
}
Console.Write("\b\b ");
Console.Write($"-> ({x2}; {y2})");