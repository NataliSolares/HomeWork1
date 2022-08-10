// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int z;
int c;
if (a % b == 0)
{
    c = a / b;
    Console.Write("Число а кратно b: " + c);
}
else
{
    z = a % b;
    Console.Write("Число а не кратно b: " + z);
}