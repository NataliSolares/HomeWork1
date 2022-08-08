// По заданному номеру дня недели вывести его название

string[] array = {"пон", "вт", "ср", "чт", "пят", "субб", "воск"};
Console.WriteLine("Ведите номер дня недели от 1 до 7 ");
string input = Console.ReadLine();
int numOfDay = int.Parse(input) - 1;
Console.WriteLine(array[numOfDay]);
