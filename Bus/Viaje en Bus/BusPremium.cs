public class BusPremium : Bus
{
    public BusPremium(int numeroPasajeros)
    {
        this.tipoBus = "Bus Premium";
        this.numeroPasajeros = numeroPasajeros;
        this.precioIncial = 150;
        this.precioIncrementado = 25;
        this.aireAcondicionado = true;
        this.television = true;
    }
}