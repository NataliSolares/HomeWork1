// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int n = new Random().Next(10, 99);
Console.Write("Выбрано число: ");
Console.WriteLine(n);
int n1 = n / 10;
int n2 = n % 10;
if(n1 > n2)
{
Console.Write(n1);
}
else {
Console.Write(n2);
}
