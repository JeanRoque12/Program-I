// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero positivo de dos digitos: ");


static bool IsPrime(int n) {
    for (int i = 1; i < n; i++) {
        if (n%2 == 0) {
            return false;
        }
    }
    return true;
}

try {
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    if (num.ToString().Length == 2) {
        int dig1 = num/10;
        int dig2 = num%10;
        if (IsPrime(dig1)) {
            Console.WriteLine(Convert.ToString(dig1) + " es un numero primo.");
        }
        else {
            Console.WriteLine(Convert.ToString(dig1) + " no es un numero primo.");
        }

        if (IsPrime(dig2)) {
            Console.WriteLine(Convert.ToString(dig2) + " es un numero primo.");
        }
        else {
            Console.WriteLine(Convert.ToString(dig2) + " no es un numero primo.");
        }
    }
    else {
        Console.WriteLine("Este numero no es de dos digitos.");
    }
}
catch {
    Console.WriteLine("Este no es un numero.");
}
