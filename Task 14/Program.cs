// Напишите программу, которая принимает на вход 2 числа и проверяет, кратно ли оно одновременно 7 и 23.

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num%7==0 && num%23==0)
{
    System.Console.WriteLine($"Число {num} кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"Число {num} некратно 7 и 23");
}
