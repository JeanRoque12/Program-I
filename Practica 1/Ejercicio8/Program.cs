// See https://aka.ms/new-console-template for more information

try {
    Console.WriteLine("Ingrese un numero entero de cinco dígitos positivo.");
    int num = Convert.ToInt32(Console.ReadLine());
    if (Convert.ToString(num).Length == 5 && num > 0) {
        string num_cap = "";
        for (int i = Convert.ToInt32(Convert.ToString(num).Length) - 1  ; i >= 0; i--) {
            char character = Convert.ToString(num)[i];
            num_cap += character;
        }
        if (Convert.ToInt32(num_cap) == num) {
            Console.WriteLine("Este numero es un numero capicua. " + num_cap + " = " + num);
        }
        else {
            Console.WriteLine("Este numero no es un numero capicua. " + num_cap + " != " + num);
        }
    }
    else {
        Console.WriteLine("Numero no valido.");
    }
}
catch {
    Console.WriteLine("Se produjo un error.");
}
