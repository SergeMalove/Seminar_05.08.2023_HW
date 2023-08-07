// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Введите целое число число: ");
int num = int.Parse(Console.ReadLine());

if (num == 0) System.Console.WriteLine("Введенное число равно нулю");
else if (num % 2 == 0) System.Console.WriteLine("Введенное число четное");
else System.Console.WriteLine("Введенное число НЕчетное");