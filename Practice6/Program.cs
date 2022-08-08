// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число: ");
string s = Console.ReadLine();
int n = int.Parse(s);
int r = n % 10;
Console.WriteLine(r);
