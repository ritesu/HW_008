Console.WriteLine("Введите количество строк Треугольника Паскаля, которые надо показать");
int a = int.Parse(Console.ReadLine() ?? "");
int i = 0;
int b = 0;
static float Factorial(int a)
{
    float i, x = 1;
    for (i = 1; i <= a; i++)
    {
        x *= i;
    }
    return x;
}
void PrintTriPas()
{
    for (i = 0; i < a; i++)
    {
        for (b = 0; b <= (a - i); b++)
        {
            Console.Write(" ");
        }
        for (b = 0; b <= i; b++)
        {
            Console.Write(" ");
            Console.Write(Factorial(i) / (Factorial(b) * Factorial(i - b)));
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

PrintTriPas();