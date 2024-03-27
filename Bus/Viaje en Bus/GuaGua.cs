public class GuaGua : Bus
{
    
    public GuaGua(int numeroPasajeros)
    {
        this.tipoBus = "\"Gua Gua\"";
        this.numeroPasajeros = numeroPasajeros;
        this.precioIncial = 50;
        this.precioIncrementado = 15;
        this.aireAcondicionado = false;
        this.television = false;
    }
}