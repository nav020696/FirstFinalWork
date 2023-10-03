Console.Write("Введите количество элементов в массиве ");
int N = int.Parse(Console.ReadLine()!);
string[] strings = FillArray(N);
string[] result = FillNewArray(strings);
PrintArray(result);


string[] FillArray(int N)
{
    string[] strings = new string[N];
    for (int indexStrings = 0; indexStrings < N; indexStrings++)
    {
        Console.Write($"Введите {indexStrings + 1} элемент массива ");
        strings[indexStrings] = Console.ReadLine()!;
    }
    return strings;
}

string[] FillNewArray(string[] strings)
{
    string[] result = new string[strings.Length];
    int indexResult = 0;
    for (int indexStrings = 0; indexStrings < strings.Length; indexStrings++)
    {
        if (strings[indexStrings].Length <= 3)
        {
            result[indexResult] = strings[indexStrings];
            indexResult++;
        }
    }
    return result;
}

void PrintArray(string[] array){
    string result = "[";
    foreach (string i in array)
    {
        if (i != null)
        {
            result += "\"" + i + "\",";
        }
    }
    if (result.Length >= 2)
    {
        Console.WriteLine(string.Concat(result.Substring(0, result.Length - 1),"]"));
    }
    else
    {
         Console.WriteLine(string.Concat(result, "]"));
    }
}