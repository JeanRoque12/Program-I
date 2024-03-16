// See https://aka.ms/new-console-template for more information

public abstract class Llamada
{
    protected string? numOrigen {get; set;}
    protected string? numDestino {get; set;}
    protected double duracion {get; set;}
    protected double? precio {get;set;}
    protected double? costoLlamada{get; set;}

    public string? GetNumOrigen() => this.numOrigen;
    public string? GetNumDestino() => this.numDestino;
    public double GetDuracion() => this.duracion;
    public double? GetPrecio() => this.precio;
    public double? GetCostoLlamada() => this.costoLlamada;
    public string _ToString() 
    {
        string? parte1 = Convert.ToString(GetNumOrigen()).PadRight(15);
        string? parte2= Convert.ToString(GetNumDestino()).PadRight(15);
        string? parte3=Convert.ToString(Math.Round(GetDuracion(), 2));
        return parte1 + parte2 + parte3;
    }
}
