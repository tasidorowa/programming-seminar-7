// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки
// Использовать рекурсию


void ShowConsonantsLetters(string s)
{
    if (s.Length == 0)
    {
        return;
    }
    string vowels = "aeiouy";
    if (char.IsAsciiLetter(s[0]) && !vowels.Contains(char.ToLower(s[0])))
    {
        Console.Write(s[0]);
    }
    ShowConsonantsLetters(s.Substring(1));
}

Console.WriteLine("Введите строку: ");

//string vowels = "aeiouy";

ShowConsonantsLetters(Console.ReadLine());

//if (char.IsAsciiLetter(s[0]) && !vowels.Contains(char.ToLower(s[0]))) Console.Write(s[0]);

//Console.Write(s.Substring(1));
// string news = s.Substring(1);
// Console.Write(news[0]);


