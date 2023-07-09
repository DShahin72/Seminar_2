// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого

System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1*num1==num2)
{
    System.Console.WriteLine($"Число {num2} является квадратом числа {num1}");
}
else if (num2*num2==num1)
{
    System.Console.WriteLine($"Число {num1} является квадратом числа {num2}");
}
else
{
    System.Console.WriteLine($"Число {num2} не является квадратом числа {num1},");
    System.Console.WriteLine($"и число {num1} не является квадратом числа {num2}.");
}
