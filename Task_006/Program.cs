Console.WriteLine("Введите размеры трехмерного массива");
int a = int.Parse(Console.ReadLine() ?? "");
int b = int.Parse(Console.ReadLine() ?? "");
int c = int.Parse(Console.ReadLine() ?? "");
int[,,] numbers = new int[a, b, c];

void FillNumbers(int[,,] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(2); k++)
            {
                numbers[i,j,k] = 10 + count;
                count++;
            }

        }

    }
}

void PrintNumbers(int[,,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(2); k++)
            {
                Console.Write(numbers[i, j, k] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

FillNumbers(numbers);
PrintNumbers(numbers);