Console.WriteLine("Введите размер массива");
int a = int.Parse(Console.ReadLine()?? "0");
int[] mass = new int [a];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(10);
}

Array.Sort(mass);
foreach (int i in mass)
{
    Console.Write(i + " ");
}
Console.WriteLine();

int count = 1;

for (int i = 0; i < mass.Length; i++)
{
    for (int j = i + 1; j < mass.Length; j++)
    {
        if ( mass[i] == mass[j])
        {
            count++;
        }
    }
    Console.WriteLine($"Число {mass[i]} повторяется {count} раз");
    Array.Reverse(mass);
    int b = mass.Length - count + 1;
    Array.Resize(ref mass, b);
    Array.Reverse(mass);
    count = 1;
}