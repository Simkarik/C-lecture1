// Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого числа

int num = new Random().Next(100, 1000);

Console.WriteLine($"Случайное число - {num}");

int n3 = num%10;
int n2 = n3%10;
int n1 = num/100;

num = n1 * 10 + n3;

Console.WriteLine($"Число без второй цифры - {num}");