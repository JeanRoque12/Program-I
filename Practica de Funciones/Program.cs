static string? Bisiesto(int ano)
{
    if (ano % 4 == 0)
    {
        return $"{ano} es un ano bisiesto.";
    }
    return null;
}

Console.WriteLine("Ingrese un ano: ");
int num = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(Bisiesto(num));
