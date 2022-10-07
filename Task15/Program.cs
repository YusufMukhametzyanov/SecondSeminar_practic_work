/* 
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


Console.Write("Введите цифру, обозначающую день недели: ");
int NumberWeek = int.Parse(Console.ReadLine());
if (NumberWeek == 6 || NumberWeek == 7)
    Console.WriteLine($"{NumberWeek} -> да");
else if (NumberWeek == 1 || NumberWeek == 2 || NumberWeek == 3 || NumberWeek == 4 || NumberWeek == 5)
    Console.WriteLine($"{NumberWeek} -> нет");
else 
    Console.WriteLine("Error");
