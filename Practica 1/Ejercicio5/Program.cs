// See https://aka.ms/new-console-template for more information


try
{
    Console.WriteLine("Escriba un numero positivo de 3 digitos: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0 && Convert.ToString(num).Length == 3) {
        int dig1 = num % 10;
        int dig2 = num / 10 % 10;
        int dig3 = num / 100;

        if (dig1 > dig2 && dig1 > dig3) {
            Console.WriteLine("El mayor digito esta en la tercera posicion, " + dig1);
        }
        else if (dig2 > dig1 && dig2 > dig3) {
            Console.WriteLine("El mayor digito esta en la segunda posicion, " + dig2);
        }
        else if (dig3 > dig1 && dig3 > dig2) {
            Console.WriteLine("El mayor digito esta en la primera posicion, " + dig3);
        }
        else if (dig1 == dig2 && dig1 > dig3) {
            Console.WriteLine("Los mayores digitos estan en la segunda y tercera posicion, " + dig1);
        }
        else if (dig1 == dig3 && dig1 > dig2) {
            Console.WriteLine("Los mayores digitos estan en la primera y tercera posicion, " + dig1);
        }
        else if (dig2 == dig3 && dig2 > dig1) {
            Console.WriteLine("Los mayores digitos estan en la primera y segunda posicion, " + dig2);
        }
        else if (dig1 == dig2 && dig2 == dig3) {
            Console.WriteLine("Todos los digitos son el mismo numero, " + dig1);
        }
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