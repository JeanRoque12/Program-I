// See https://aka.ms/new-console-template for more information


try
{
    Console.WriteLine("Escriba un numero: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Escriba otro numero: ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > b) {
        Console.WriteLine("Escribe otro numero: ");
        b = Convert.ToInt32(Console.ReadLine());
        if (a > b) {
            Console.WriteLine(a + " es el numero mas grande de los introducidos.");
        }
        else {
            Console.WriteLine(b + " es el numero mas grande de los introducidos.");
        }
    }
    else {
        Console.WriteLine("Escribe otro numero: ");
        a = Convert.ToInt32(Console.ReadLine());
        if (b > a) {
            Console.WriteLine(b + " es el numero mas grande de los introducidos.");
        }
        else {
            Console.WriteLine(a + " es el numero mas grande de los introducidos.");
        }
    }
}
catch {
    Console.WriteLine("Se produjo un error.");
}
