// See https://aka.ms/new-console-template for more information

static string? IsMultiple(int num1, int num2) {
    if (num1 % num2 == 0) {
        string answer = num1 + " es un multiplo de " + num2 + ".";
        return answer;
    }
    return null;
}
static void Print(string? ok){
    if (ok == null) {
        return;
    }
    else {
        Console.WriteLine(ok);
    }
}

try
{
    Console.WriteLine("Escriba un numero positivo de 3 digitos: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0 && Convert.ToString(num).Length == 3) {
        int dig1 = num % 10;
        int dig2 = num / 10 % 10;
        int dig3 = num / 100;
        Print(IsMultiple(dig1, dig2));
        Print(IsMultiple(dig2, dig1));
        Print(IsMultiple(dig1, dig3));
        Print(IsMultiple(dig3, dig1));
        Print(IsMultiple(dig2, dig3));
        Print(IsMultiple(dig3, dig2));

        }
    else if (num < 0) {
        Console.WriteLine("Este numero es negativo.");
    }
    else if (Convert.ToString(num).Length != 3) {
        Console.WriteLine("Este numero no es de tres digitos.");
    }
}
catch{
    Console.WriteLine("Este no es un numero.");
}
