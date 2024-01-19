// See https://aka.ms/new-console-template for more information
try {
    Console.WriteLine("Escriba un numero: ");
    int num1 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Escribe otro numero: ");
    int num2 = Convert.ToInt16(Console.ReadLine());
    if (Math.Max(num1, num2)  - Math.Min(num1, num2) <= 10) {
        Console.WriteLine("Numeros que se encuentran entre " + Math.Min(num1, num2) + " y " + Math.Max(num1, num2));
        for (int i = Math.Min(num1, num2) + 1 ; i < Math.Max(num1, num2) ; i++) {
            Console.WriteLine(i);
        }

    }
}
catch {

}
