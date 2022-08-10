// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());
int x = (n % 10);

if ( n > 100)
{
    Console.WriteLine("Tретья цифра числа: " + x);
}
else
{
     Console.WriteLine("Нет третей цифры");
}