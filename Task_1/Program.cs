// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое число > ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число > ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber > secondNumber)
{
    Console.WriteLine($"Минимальное число > {secondNumber}");
    Console.WriteLine($"Максимальное число > {firstNumber}");
}
else
{
    Console.WriteLine($"Минимальное число > {firstNumber}");
    Console.WriteLine($"Максимальное число > {secondNumber}");
}