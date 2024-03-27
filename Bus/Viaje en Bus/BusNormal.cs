public class BusNormal : Bus
{
    public BusNormal(int numeroPasajeros)
    {
        this.tipoBus = "Bus Normal";
        this.numeroPasajeros = numeroPasajeros;
        this.precioIncial = 100;
        this.precioIncrementado = 20;
        this.aireAcondicionado = true;
        this.television = false;
    }
}