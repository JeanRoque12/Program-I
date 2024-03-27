
public abstract class Bus
{
    protected int precioIncial {get; set;}
    protected string? tipoBus {get; set;}
    protected bool aireAcondicionado {get; set;}

    protected bool television {get; set;}
    protected int numeroPasajeros {get; set;}
    protected int precioIncrementado {get; set;}

    public int GetPrecioInicial()
    {
        return this.precioIncial;
    }

    public bool HayAireAcondicionado() 
    {
        return this.aireAcondicionado;
    }

    public int GetNumeroPasajeros()
    {
        return this.numeroPasajeros;
    }

    public bool HayTelevision()
    {
        return this.television;
    }
    public int GetPrecioIncremento()
    {
        return this.precioIncrementado;
    }
    public string? GetTipoBus()
    {
        return tipoBus;
    }
}
