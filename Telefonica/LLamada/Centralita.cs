public class Centralita
{
    protected List<Llamada> llamadasLocales {get; set;}
    protected List<Llamada> llamadasProvinciales {get; set;}
    protected int cantidadLlamadas {get; set;}
    protected double? cantidadGanancias {get; set;}

    public Centralita()
    {

        this.cantidadLlamadas = 0;
        this.cantidadGanancias = 0;
    }
    public void RegistrarLLamada(Llamada llamada) // Se añade la llamada y dependiendo del tipo de llamada, se adentra a una de las listas de llamadas.
    {
        Type tipo = llamada.GetType();
        if (tipo.Equals(typeof(LlamadaLocal)))
        {
            this.llamadasLocales.Add(llamada);
            this.cantidadLlamadas ++;
            this.cantidadGanancias += llamada.GetCostoLlamada();
        }
        if (tipo.Equals(typeof(LlamadaProvincial)))
        {
            this.llamadasProvinciales.Add(llamada);
            this.cantidadLlamadas++;
            this.cantidadGanancias += llamada.GetCostoLlamada();
        }
    }
    public bool ManejarLlamadasLocales()
    {
        List<Llamada?>? llamadas = llamadasLocales;
        Console.WriteLine("   Origen".PadRight(18) + "Destino".PadRight(15) + "Duracion");
        for (int i = 0; i < llamadas.Count(); i++)
        {
            Console.WriteLine($"{i + 1}) {llamadas.ElementAt(i)._ToString()}");
        }
        Console.WriteLine();
        Console.Write("Eliga una opcion (Eliga 0 para salir):");

        int decision = int.Parse(Console.ReadLine());

        if (decision != 0)
        {
            Llamada llamadaElegida = llamadas.ElementAt(decision-1);
            Console.WriteLine($"Origen de la llamada: {llamadaElegida.GetNumOrigen}");
            Console.WriteLine($"Destino de la llamada: {llamadaElegida.GetNumDestino}");
            Console.WriteLine($"Duracion de la llamada: {llamadaElegida.GetDuracion}");
            Console.WriteLine($"Precio de la llamada por segundos: {llamadaElegida.GetPrecio}");
            Console.WriteLine($"Costo de la llamada {llamadaElegida.GetCostoLlamada}");
            Console.WriteLine("");
            Console.Write("Precion ENTER para continaur:");
            Console.Read();
            return true;
        }
        else
        {
            return false;
        }

    }
    public bool ManejarLlamadasProvinciales()
    {
        List<Llamada?>? llamadas = this.llamadasProvinciales;
        Console.WriteLine("   Origen".PadRight(18) + "Destino".PadRight(15) + "Duracion");
        for (int i = 0; i < llamadas.Count(); i++)
        {
            Console.WriteLine($"{i + 1}) {llamadas.ElementAt(i)._ToString()}");
        }
        Console.WriteLine();
        Console.Write("Eliga una opcion (Eliga 0 para salir):");

        int decision = int.Parse(Console.ReadLine());
        if (decision != 0)
        {
            Llamada? llamadaElegida = llamadas.ElementAt(decision-1);
            Console.WriteLine($"Origen de la llamada: {llamadaElegida.GetNumOrigen}");
            Console.WriteLine($"Destino de la llamada: {llamadaElegida.GetNumDestino}");
            Console.WriteLine($"Duracion de la llamada: {llamadaElegida.GetDuracion}");
            Console.WriteLine($"Precio de la llamada por segundos: {llamadaElegida.GetPrecio}");
            Console.WriteLine($"Costo de la llamada {llamadaElegida.GetCostoLlamada}");
            Console.WriteLine("");
            Console.Write("Precion ENTER para continaur:");
            Console.Read();
            return true;
        }
        else
        {
            return false;
        }

    }
    public int GetCantidadLlamadas() => this.cantidadLlamadas;
    public double?GetCantidadGanancias() => this.cantidadGanancias;
}