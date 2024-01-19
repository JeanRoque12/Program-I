// See https://aka.ms/new-console-template for more information
try {
    Console.WriteLine("Escriba un numero de 4 digitos: ");
    int num = Convert.ToInt16(Console.ReadLine());
    if (Convert.ToString(num).Length == 4 && num > 0) {
        int dig2 = num / 100 % 10;
        int dig3 = num / 10 % 10;
        if (dig2 == dig3) {
            Console.WriteLine("El segundo y penulitmo digito son iguales.");
        }
        else {
            Console.WriteLine("El segundo y penultimo digito no son iguales.");
        }
    }
    else {
        Console.WriteLine("Numero no valido.");
    }
}
catch {
    Console.WriteLine("Se produjo un error.");
}