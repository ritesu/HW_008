Console.WriteLine("Введите текст");
string text = Console.ReadLine() ?? "";
char[] symbols = new char[text.Length];
int count = 1;
int temp = 1;
char symbol;
double a = 0;
int c = 0;
int d = 0;
int k = 0;
int e = 0;
char[] symbolArray = new char[35];
int[] numbers = new int[35];

void FillArray(char[] symbols)
{
    text = text.ToLower();
    for (int i = 0; i < text.Length; i++)
    {
        symbols[i] = text[i];
    }
}

void NumberOfSymbols()
{
    count = 0;
    for (int i = 0; i < symbols.Length; i++)
    {
        a++;
        e++;
    }
}

void CreatArrays()
{
    for (int i = 0; i < symbols.Length; i++)
    {
        count = 1;
        for (int j = i + 1; j < symbols.Length; j++)
        {
            if (symbols[i] == symbols[j])
            {
                count++;
            }
            k = e - count - k;
        }
    }
    symbolArray = new char[k];
    numbers = new int [k];
}

void CheckArray(char[] symbols)
{
    temp = 1;
    for (int i = 0; i < symbols.Length; i = i + temp)
    {
        symbol = symbols[i];
        count = 1;
        for (int j = i + 1; j < symbols.Length; j++)
        {
            if (symbols[i] == symbols[j])
            {
                count++;
            }
        }
        temp = count;
        symbolArray[c] = symbols[i];
        numbers[d] = count;
        c++;
        d++;
    }
}

void SortArrays()
{
    for (int i = 0; i < numbers.Length; i++)
    {
        int max = 0;
        char min;
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[j] > numbers[i])
            {
                max = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = max;
                min = symbolArray[i];
                symbolArray[i] = symbolArray[j];
                symbolArray[j] = min;
            }
        }
    }
    count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == 0)
        {
            count++;
        }
    }
    k = k-count;
    Array.Resize(ref numbers, k);
    Array.Resize(ref symbolArray,k);
}

void PrintResult()
{
    for (int i = 0; i < numbers.Length; i++)
    {
        double b = numbers[i] / a * 100;

        if (symbolArray[i] == ' ')
        {
            Console.WriteLine($"Символ пробел/space был введ {numbers[i]}. Частота {Math.Round(b, 2)}%");
        }
        else
        {
            Console.WriteLine($"Символ {symbolArray[i]} повторяется {numbers[i]} раз. Частота {Math.Round(b, 2)}%");
        }
    }
}

FillArray(symbols);
Array.Sort(symbols);
NumberOfSymbols();
CreatArrays();
CheckArray(symbols);
SortArrays();
Console.WriteLine();
PrintResult();