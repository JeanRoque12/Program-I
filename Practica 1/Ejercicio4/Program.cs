// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escriba un número positivo entero de dos dígitos: " );

try{
    int num1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine("Escriba otro numero positivo de dos digitos: ");
    int num2 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
   if (Convert.ToString(num1).Length == 2 && Convert.ToString(num2).Length == 2) {
        int sum = num1 + num2;
        if (sum%2==0) {
            Console.WriteLine("La suma de los dos numeros, " + sum + ", es un numero par");
        }
        else {
            Console.WriteLine("La suma de los dos numeros, " + sum + ", no es un numero par");
        }
    }
    else {
        Console.WriteLine("Uno de los dos numeros no es de dos digitos.");
    }
}
catch {
    Console.WriteLine("Ese no es un numero.");
}
