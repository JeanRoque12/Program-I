// See https://aka.ms/new-console-template for more information


static void Suma(int a, int b){
    Console.WriteLine(Convert.ToString(a + b));
}

static void Multiplicacion(int a, int b) {
    Console.WriteLine(Convert.ToString(a * b));
}

static void Resta(int a, int b) {
    Console.WriteLine(Convert.ToString(a - b));
}

static void Division(int a, int b){
    Console.WriteLine(Convert.ToString(a / b));
}

bool estado = true;

while (estado) {
    Console.WriteLine("""
    a) Sumar 
    b) Restar
    c) Multiplicar
    d) Dividir
    e) Terminar
    Que accion desea tomar?
    """);
    string? decision = Console.ReadLine();
    Console.WriteLine("Eligar un numero: ");
    int num1 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Eliga otro numero: ");
    int num2 = Convert.ToInt16(Console.ReadLine());
    if (decision == "a") {
        Suma(num1, num2);
        Console.WriteLine("Click ENTER para continuar.");
        Console.ReadLine();
    } 
    else if (decision == "b") {
        Resta(num1, num2);
        Console.WriteLine("Click ENTER para continuar.");
        Console.ReadLine();
    }
    else if (decision == "c") {
        Multiplicacion(num1, num2);
        Console.WriteLine("Click ENTER para continuar.");
        Console.ReadLine();
    }
    else if (decision == "d") {
        if (num2 == 0) {
            Console.WriteLine("Esta operacion no es valida.");
            Console.WriteLine("Click ENTER para continuar.");
            Console.ReadLine();
        }
        else {
            Division(num1, num2);
            Console.WriteLine("Click ENTER para continuar.");
            Console.ReadLine();
        }
    }
    else if (decision == "e") {
        estado = false;
    }

}
