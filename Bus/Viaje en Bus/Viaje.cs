
public class Viaje
{
    private Bus bus {get; set;}
    private string ruta {get; set;}
    private double distancia {get; set;}
    private double precioDelViaje {get; set;}
    private double gananciaTotal {get; set;}

    public Viaje(Bus bus, string ruta, double distancia)
    {
        this.bus = bus;
        this.ruta = ruta;
        this.distancia = distancia;
        precioDelViaje = bus.GetPrecioInicial() + (distancia / 50)*bus.GetPrecioIncremento();
        gananciaTotal = (double)precioDelViaje*bus.GetNumeroPasajeros();

    }

    public string GetRuta()
    {
        return this.ruta;
    }
    public Bus GetBus()
    {
        return this.bus;
    }
    public double GetDistancia()
    {
        return this.distancia;
    }
    public double GetPrecioDelViaje()
    {
        return this.precioDelViaje;
    }
    public double GetGananciaTotal()
    {
        return this.gananciaTotal;
    }
}