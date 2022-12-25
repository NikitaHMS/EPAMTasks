Console.Write("Введите слово: ");

string word = Console.ReadLine();

char[] unequal = word.Distinct().ToArray();

int length = unequal.Length;

Console.WriteLine($"Количество неодинаковых букв: {length}");