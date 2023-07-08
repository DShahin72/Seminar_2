// Напишите программу, которая будет принимать на вход два числа и проверять, является ли
// второе число кратным первому. Если нет, то выводить остаток от деления.

int M = new Random().Next(1, 100);
int N = new Random().Next(1, 100);
System.Console.WriteLine(M);
System.Console.WriteLine(N);

if (N % M == 0)
{
    System.Console.WriteLine($"Число {N} кратно числу {M}");
}
else
{
    System.Console.WriteLine($"Число {N} некратно числу {M}. Остаток от деления равен {N % M}");
}