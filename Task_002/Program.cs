Console.WriteLine("Введите количество строк и столбцов");
int row = int.Parse(Console.ReadLine() ?? "");
int colum = int.Parse(Console.ReadLine() ?? "");
int[,] mass = new int[row, colum];
Console.WriteLine("Введите отрезок значений для заполнения массива, от и до");
int a = int.Parse(Console.ReadLine() ?? "");
int b = int.Parse(Console.ReadLine() ?? "");
b = b + 1;

void FillMass(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(a, b);
        }
    }
}

void PrintMass(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int count = 0;
int k = 0;

void PrintResult(int[,] mass)
{
    if (count > 0)
        {
            Console.WriteLine($"Число {k} повторяется {count} раз");
        }
}

void CheckMass(int[,] mass)
{
    for (k = a; k < b; k++)
    {
        count = 0;
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                if (k == mass[i,j])
                {
                    count++;
                }
            }
        }
        PrintResult(mass);
    }
}




FillMass(mass);
PrintMass(mass);
CheckMass(mass);
Console.WriteLine();
