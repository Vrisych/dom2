// По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();
Console.WriteLine("Введите целое число и я покажу является ли первое квадратом второго");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1==num2*num2)
{
    Console.WriteLine($"Да, число {num1} является квадратом {num2}");
}
else Console.WriteLine($"Нет, число {num1} не является квадратом {num2}");