Console.WriteLine("Введите размеры трехмерного массива");
int a = int.Parse(Console.ReadLine() ?? "");
int b = int.Parse(Console.ReadLine() ?? "");
int c = int.Parse(Console.ReadLine() ?? "");
int[] numbers = new int[90];
int[,,] numbers2 = new int[a, b, c];

void FillNumbers(int[] numbers)
{
    int d = 10;
    for (int i = 0; i < numbers.Length; i++)
    {



        numbers[i] = d;
        d++;



    }
}

void PrintNumbers(int[] numbers)
{
    foreach(int i in numbers)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

void ChangeIndexes()
{
    a = 0;
    b = 0;
    c = 0;
    for (int d = 1; d < 91; d++)
    {
        int i = new Random().Next(0, numbers.Length);
        int max = numbers[a];
        numbers[a] = numbers[i];
        numbers[i] = max;
    }
}

int[,,] newNumbers = new int[a, b, c];


void FillNewNumbers(int[,,] newNumbers)
{
    a = 0;
    for (int i = 0; i < newNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < newNumbers.GetLength(1); j++)
        {
            for (int k = 0; k < newNumbers.GetLength(2); k++)
            {
                newNumbers[i, j, k] = numbers[a];
                a++;
            }
        }
    }
}

void PrintNewNumbers(int[,,] newNumbers)
{
    for (int i = 0; i < newNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < newNumbers.GetLength(1); j++)
        {
            for (int k = 0; k < newNumbers.GetLength(2); k++)
            {
                Console.Write($"{newNumbers[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

FillNumbers(numbers);
PrintNumbers(numbers);
ChangeIndexes();
Console.WriteLine();
FillNewNumbers(newNumbers);
Console.WriteLine();
PrintNewNumbers(newNumbers);