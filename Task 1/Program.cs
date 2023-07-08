// Напишите программу, которая выводит случайное число от 10 до 99 и определяет наиболшую цифру в нем

Random randnum = new Random();
int N = randnum.Next(10, 100);

//int N = new Random().Next(10, 100);

System.Console.WriteLine(N);
int maxFigure = 0;

if (N/10>N%10)
{
    maxFigure = N / 10;
}
else
{
    maxFigure = N % 10;
}

System.Console.WriteLine($"Максимальная цифра числа {N} равна {maxFigure}");