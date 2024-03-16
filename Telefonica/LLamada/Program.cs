public class Programa    
{     

    public static void Main(string[] args)     
    {   
        Centralita centralita = new Centralita();
        LlamadaLocal llamada = new LlamadaLocal("333", "222", 30.2);
        int opcion;

        do {
            Console.WriteLine(@"
1) Manejar Llamadas Locales
2) Manejar Llamadas Provinciales
3) Registrar Llamada
4) Cantidad de Llamadas
5) Ganacias Totales
6) Salir");
            Console.WriteLine();
            Console.WriteLine("Cual opcion quiere tomar?");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    bool resultado1;
                    do 
                    {
                        resultado1 = centralita.ManejarLlamadasLocales();
                    } while (resultado1);
                    break;
                case 2:
                    bool resultado2;
                    do
                    {
                        resultado2 = centralita.ManejarLlamadasProvinciales();
                    } while (resultado2);
                    break;
                case 3:
                    Console.WriteLine(@"
                    Que tipo de llamada va a registrar?
                    1) Llamada Local
                    2) Llamada Provincial
                    ");
                    int tipo = int.Parse(Console.ReadLine());
                    if (tipo == 2)
                    {
                        Console.Write("Introzuca el numero origen:"); 
                        string? origen = Console.ReadLine();
                        Console.Write("Introduzca el numero destino:");
                        string? destino = Console.ReadLine();
                        Console.Write("Introduzca la duracion de la llamada:");
                        double duracion = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Introduzca la franja:");
                        int franja = int.Parse(Console.ReadLine());
                        centralita.RegistrarLLamada(new LlamadaProvincial(origen, destino, duracion, franja));
                        Console.Write("Se registro la llamada excitosamente. Presion ENTER para continuar: ");
                    }
                    else 
                    {
                        Console.Write("Introzuca el numero origen:"); 
                        string? origen = Console.ReadLine();
                        Console.Write("Introduzca el numero destino:");
                        string? destino = Console.ReadLine();
                        Console.Write("Introduzca la duracion de la llamada:");
                        double duracion = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Introduzca la franja:");
                        centralita.RegistrarLLamada(new LlamadaLocal(origen, destino, duracion));
                        Console.Write("Se registro la llamada excitosamente. Presion ENTER para continuar: ");                        
                    }
                    break;
                case 4:
                    Console.WriteLine($"Cantidad de llamadas totales: {centralita.GetCantidadLlamadas}.");
                    break;
                case 5:
                    Console.WriteLine(String.Format($"Cantidad de ganancias totales: {0:C2}", centralita.GetCantidadGanancias));
                    break;
                case 6:
                    Console.WriteLine("Adios!");
                    break;
                default:
                    Console.WriteLine("Adios!");
                    opcion = 6;
                    break;

                    
            }

            
        } while(opcion != 6);
    }     
}