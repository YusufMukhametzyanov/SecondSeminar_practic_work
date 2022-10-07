/* 
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

void Task13()
{
int a = (new Random().Next(0, 1000));
if (a > 100)
{
    string b = a.ToString();
    int result = int.Parse(b[2].ToString());
    Console.WriteLine($"{a} -> {result}");
}
else

    Console.WriteLine($"{a} -> третьей цифры нет");
}

Task13();




