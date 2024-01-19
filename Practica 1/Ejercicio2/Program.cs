// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero: ");

try {
    int num = Convert.ToInt32(Console.ReadLine());
    int valor_abs = Math.Abs(num);
    if (valor_abs.ToString().Length == 2) {
        if (num < 0) {
            Console.WriteLine("Es numero es negativo");
        }
        else {
            int prime_count = 0;
            for (int i = 2; i < num; i++) {
                if (num%i == 0) {
                    prime_count += 1;
                }
            }
            if (prime_count > 0) {
                Console.WriteLine("Este no es un numero primo.");
            }
            else {
                Console.WriteLine("Este es un numero primo.");
            }
            Console.WriteLine("Este numero es positivo");
        }
    }
    else {
        if (num<0) {
            Console.WriteLine("Este numero no es de dos digitos y ademas es negativo.");
        }
        else {
            Console.WriteLine("Este numero no es de dos digitos.");
        }
        
    }
}
catch {
    Console.WriteLine("Este no es un numero.");
}