// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
//Обязательна проверка на ввод чисел больше/меньше 3-х знаков

/*
Console.WriteLine ("Введите трехзначное число: ");
string numbers = Console.ReadLine ()!;
if (numbers.Length != 3) Console.WriteLine ("Введено неверное число!");
else Console.WriteLine ($"Вторая цифра: {numbers[1]}");
*/





//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//Берем числа до 100000

/*
// Первый вариант: Через генератор случайных чсел
int number1 = new Random().Next(1, 100000);
Console.WriteLine (number1);
string str = Convert.ToString(number1);
if (str.Length < 3) Console.WriteLine("Третьей цифры не существует!");
else Console.WriteLine($"Третья цифра: {str[2]}");
*/

// Второй вариант: задаем число вручную
/*
Console.WriteLine("Введите число: ");
string numbers1 = Console.ReadLine()!;
if (numbers1.Length < 3) Console.WriteLine("Третьей цифры не существует!");
else Console.WriteLine($"Третья цифра: {numbers1[2]}");
*/




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
// Обязательна проверка на ввод числа <1 и >8

Console.WriteLine("Введите число от 1 до 7: ");
int numbers2 = int.Parse(Console.ReadLine()!);
if ((numbers2 <1) || (numbers2 > 7)) Console.WriteLine($"Введенное число {numbers2} некорректное, введите заново!");
else
{
    if (numbers2 == 6 || numbers2 == 7) Console.WriteLine($"Введенное число совпадает с выходным днем недели.");
    else Console.WriteLine($"Введенное число не совпадает с выходным днем недели.");
}