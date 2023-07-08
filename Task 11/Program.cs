// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

int N = new Random().Next(100, 1000);
//System.Console.WriteLine(N);

System.Console.WriteLine($"{N} -> {N/100*10+N%10}");