Console.WriteLine("Введите количество строк и столбцов для двух массивов");
int row = int.Parse(Console.ReadLine() ?? "");
int colum = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите промежуток чисел, которыми заполнить массивы");
int a = int.Parse(Console.ReadLine() ?? "");
int b = int.Parse(Console.ReadLine() ?? "");
b = b + 1;
int[,] mass = new int[row, colum];

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

int numb1 = 0;
int numb2 = 0;

void CheckMass(int[,] mass)
{
    int count = 0;
    for (int k = a; k < b; k++)
    {
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                if (k == mass[i, j])
                {
                    numb1 = i;
                    numb2 = j;
                    count++;
                    break;
                }
            }
            if (count > 0)
            {
                break;
            }
        }
        if (count > 0)
        {
            break;
        }
        
    }
}


void ChangeMass(int[,] mass)
{
    int max = 0;
    if (numb1 < mass.GetLength(1))
    {
        for (int i = numb1; i < mass.GetLength(0); i++)
        {
            for (int k = i + 1; k < mass.GetLength(0);)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    max = mass[i, j];
                    mass[i, j] = mass[k, j];
                    mass[k, j] = max;
                }
                break;
            }
        }
    }

    if (numb2 < mass.GetLength(0))
    {
        for (int j = numb2; j < mass.GetLength(1); j++)
        {
            for (int k = j + 1; k < mass.GetLength(1);)
            {
                for (int i = 0; i < mass.GetLength(0); i++)
                {
                    max = mass[i, j];
                    mass[i, j] = mass[i, k];
                    mass[i, k] = max;
                }
                break;
            }
        }
    }
}

int[,] NewMass = new int[mass.GetLength(0) - 1, mass.GetLength(1) - 1];

void FillNewMass(int[,] NewMass)
{
    for (int i = 0; i < NewMass.GetLength(0); i++)
    {
        for (int j = 0; j < NewMass.GetLength(1); j++)
        {
            NewMass[i, j] = mass[i, j];
        }
    }
}

void PrintNewMass(int[,] NewMass)
{
    for (int i = 0; i < NewMass.GetLength(0); i++)
    {
        for (int j = 0; j < NewMass.GetLength(1); j++)
        {
            Console.Write(NewMass[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillMass(mass);
PrintMass(mass);
CheckMass(mass);
ChangeMass(mass);
FillNewMass(NewMass);
Console.WriteLine();
PrintNewMass(NewMass);