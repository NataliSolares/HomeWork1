// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число: ");
string s = Console.ReadLine();
string r = "";
r = r + s[0];
r = r + s[2];
Console.WriteLine(r);

