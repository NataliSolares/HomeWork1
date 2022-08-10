// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите трёхзначное число");
int a = int.Parse(Console.ReadLine());
int r = a % 10;

if(a<100)
{
    Console.Write("У введённого числа нет третьей цифры");
}
else
{
    Console.WriteLine("Третья цифра числа: " + r);
}

    