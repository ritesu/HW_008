Console.WriteLine("Введите количество строк и столбцов для двух массивов");
int row = int.Parse(Console.ReadLine()?? "");
int colum = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите промежуток чисел, которыми заполнить массивы");
int a = int.Parse(Console.ReadLine()?? "");
int b = int.Parse(Console.ReadLine()?? "");
b = b + 1;
int[,] mass1 = new int[row, colum];
int[,] mass2 = new int[row, colum];
int[,] mass3 = new int[row, colum];
void FillMass()
{
    for (int i = 0; i < mass1.GetLength(0); i++)
    {
        for (int j = 0; j < mass1.GetLength(1); j++)
        {
            mass1[i,j] = new Random().Next(a, b);
            mass2[i,j] = new Random().Next(a, b);
        }
    }
}

void PrintMass()
{
    for (int i = 0; i < mass1.GetLength(0); i++)
    {
        for (int j = 0; j < mass1.GetLength(1); j++)
        {
            Console.Write(mass1[i,j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    for (int i = 0; i < mass2.GetLength(0); i++)
    {
        for (int j = 0; j < mass2.GetLength(1); j++)
        {
            Console.Write(mass2[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void Multiplication()
{
    for (int i = 0; i < mass1.GetLength(0); i++)
    {
        for (int j = 0; j < mass1.GetLength(1); j++)
        {
           mass3[i,j] = mass1[i,j] * mass2[i,j];
        }
        
    }
}

void PrintResult()
{
    for (int i = 0; i < mass3.GetLength(0); i++)
    {
        for (int j = 0; j < mass3.GetLength(1); j++)
        {
               Console.Write(mass3[i,j] + " ");
        }
        Console.WriteLine();        
    }
}

FillMass();
PrintMass();
Multiplication();
Console.WriteLine();
PrintResult();