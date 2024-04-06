void Orden()
{
    Menu();

    int opcion = Convert.ToInt16(Console.ReadLine());

    Hamburguesa hamburguesa;
    string pan;
    string carne;

    switch (opcion)
    {
        case 2:
            hamburguesa = new Saludable();
            hamburguesa.AnadirIngredientes();
            while (hamburguesa.GetIngredientes().Count() < 2)
            {
                Console.Write("Esta hamburguesa requiere minimo 2 ingredientes adicionales. Presion ENTER para continuar");
                Console.ReadLine();
                hamburguesa.AnadirIngredientes();
            }
            hamburguesa.Factura();
            Continuar();
            break;
        case 3:
            pan = ElegirPan();
            carne = ElegirCarne();
            hamburguesa = new Premium(pan, carne);
            hamburguesa.AnadirIngredientes();
            Console.Write("Presion ENTER para continuar: ");
            Console.ReadLine();
            hamburguesa.Factura();
            Continuar();
            break;
        default: // Default tambien incluye al caso 1 de hamburugesa clasica
            pan = ElegirPan();
            carne = ElegirCarne();
            hamburguesa = new Clasica(pan, carne);
            hamburguesa.AnadirIngredientes();
            Console.Write("Presion ENTER para continuar: ");
            Console.ReadLine();
            hamburguesa.Factura();
            Continuar();
            break;
    }
}

Orden(); // Inicio del programa

string ElegirPan()
{
    Console.WriteLine("Que clase de pan quiere que tenga su hamburguesa? ");
    Console.WriteLine($"1) Normal\n2) Integral\n3) Negro\n\n*Si no elige ninguna opcion valida, se asumira que eligio el pan normal*\n");
    var opcion = Convert.ToInt16(Console.ReadLine());
    switch (opcion)
    {
        case 2:
            return "Pan Integral";
        case 3:
            return "Pan Negro";
        default:
            return "Pan Normal";
    }
}

string ElegirCarne()
{
    Console.WriteLine("Que clase de carne quiere que tenga su hamburguesa? ");
    Console.WriteLine($"1) Carne de res\n2) Carne de pollo\n3) Carne organica\n\n*Si no elige ninguna opcion valida, se asumira que eligio la carne de res*\n");
    var opcion = Convert.ToInt16(Console.ReadLine());
    switch (opcion)
    {
        case 2:
            return "Carne de pollo";
        case 3:
            return "Carne organica";
        default:
            return "Carbe de res";
    }
}

void Continuar()
{
    Console.WriteLine("Que desea hacer ahora? \n1) Cambiar pedido\n2) Salir\n");
    int opcion = Convert.ToInt16(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Orden();
            break;
        default:
            break;
    }
}

void Menu()
{
Console.WriteLine(@"
Bienvenidos a Chimi MiBarriga! Que tipo de hamburguesa desea comprar hoy?

1) Clasica (Puedes agregarle 4 ingredientes adicionales)
2) Saludable (Pan integral y carne organica, con hasta 6 ingredientes exclusivamente saludables)
3) Premium (Trae papas fritas y bebida, pero no se le puede agregar ingredientes adicionales)

*Si no elige ninguna opcion valida, se asumira que eligio una hamburguesa clasica.* 

");
}