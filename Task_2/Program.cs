// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число > ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число > ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число > ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int MAX = firstNumber;
if(firstNumber > MAX)
{
    MAX = firstNumber;
}
if(secondNumber > MAX)
{
    MAX = secondNumber;
}
if(thirdNumber > MAX)
{
    MAX = thirdNumber;
}
Console.WriteLine($"Максимальное число > {MAX}");