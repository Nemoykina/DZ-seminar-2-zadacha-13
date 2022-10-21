// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число: ");
Console.WriteLine("Показать третью цифру числа: ");
int x = int.Parse(Console.ReadLine()!);
int num = x;
int x1 = x / 10;
if (num <= 2)
{
    Console.WriteLine($"Третьей цифры нет.");
}
else
{
    if (num  > 3)
    {
       num = num % 10;
       Console.WriteLine($"Третья цифра числа {num} -> {(x % 10)}");
    }
    else 
    num = num % 10;
    {
        Console.WriteLine($"Число {num} имеет меньше трех знаков, третьей цифры нет.");
    }  
}