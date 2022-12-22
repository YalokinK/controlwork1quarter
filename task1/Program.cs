// Программа для решения этой задачи
Console.WriteLine("Введите слова или числа через запятую: ");
string strText = Console.ReadLine();
string [] substring = strText.Split(',');
int count = 3;
Console.WriteLine("Выделенные строки <= 3 символов: ");
for (int i=0; i<substring.Length; i++)
{
    if (substring[i].Length <= count)
    {
        Console.Write($"[{substring[i]}] ");
    }
}

