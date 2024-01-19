// See https://aka.ms/new-console-template for more information


Console.WriteLine("Ingrese un numero de dos digitos: ");
try {
    int num = Convert.ToInt32(Console.ReadLine());
    if (num.ToString().Length == 2) {
        int sum = (num/10) + (num % 10);
        Console.WriteLine("La suma de los dos digitos es: " + sum);
    }
}
catch (Exception) {
    Console.WriteLine("No es un numero.");
}

