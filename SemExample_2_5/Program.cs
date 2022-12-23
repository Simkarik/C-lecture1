//Напишите программу, которая принимает на вход два
//числа и проверяет, является ли одно число квадратом
//другого.

Console.WriteLine("Введите первое число");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n2 = int.Parse(Console.ReadLine());

if (n1*n1 == n2 || n2*n2 == n1 )
{
    Console.WriteLine($"Квадрат");
}
else
{
    Console.WriteLine($"Не квадрат");
}