// Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
double f(int arg1, int arg2)
{
    double kv = (Math.Pow((arg1-arg2), 2));
    return kv;
}
Console.WriteLine("Введите три координаты первой точки (для решения на плоскости третьей координатой введите 0)");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите три координаты второй точки (для решения на плоскости третьей координатой введите 0)");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
double leght = Math.Sqrt(f(x1, x2)+f(y1, y2)+f(z1, z2));
Console.WriteLine($"Расстояние между точками равно {leght}");