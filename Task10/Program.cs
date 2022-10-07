/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

void Task10()
{
    int a = (new Random()).Next(100, 1000);
    Console.WriteLine($"Трёхзначное число: {a}");
    string b = a.ToString();
    int result = int.Parse(b[1].ToString());
    Console.WriteLine($"Второе число: {result}");
}

Task10();