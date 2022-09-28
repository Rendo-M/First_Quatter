string[] CreateStringArray(int n)
{
    string [] newArr; 
    string s = Console.ReadLine()!;
    if (s != "")
    {
        newArr = CreateStringArray(n+1);
        newArr[newArr.Length - n - 1] = s;
    }
    else 
        newArr = new string [n];
    return newArr;        
}

int CountSameSizeElement(string [] msg, int size)
{
    int count = 0;
    for (int i = 0; i < msg.Length; i++)
        count += Convert.ToByte(msg[i].Length == size);
    return count;
}

string [] GetAllStringsBySize(string [] msg, int size)
{
    string [] result = new string[CountSameSizeElement(msg, size)];
    int count  = 0;
    for (int i = msg.Length-1; i >= 0; i--)
        if (msg[i].Length == size)
            {
                result[count] = msg[i];
                count++;
            }
    return result;
}

void PrintStringArray(string [] txt)
{
    for (int i = 0; i < txt.Length; i++)
    {
        Console.BackgroundColor = (ConsoleColor)(1);
        Console.ForegroundColor = (ConsoleColor)(12);
        Console.Write(txt[i]);
        Console.ResetColor();
        Console.Write(" ");
    }
}


Console.Clear();
Console.WriteLine("Вводите строки текста. Признак окончания ввода - ввод пустой строки");
int size = 3;
string [] text = CreateStringArray(0);
string [] threeSymbTexts = GetAllStringsBySize(text, size);
Console.Write($"введены следующие {threeSymbTexts.Length} комбинации из {size} знаков: ");
PrintStringArray(threeSymbTexts);