// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Clear();
Console.WriteLine("Введите целое число от 1 до 7, соответствующий дню недели");
int num = int.Parse(Console.ReadLine());
if (num >= 1 && num <= 5) Console.WriteLine("Сегодня будний день");
else if (num == 6 || num == 7) Console.WriteLine("Сегодня выходной");
else Console.WriteLine("Число не попало в промежуток");