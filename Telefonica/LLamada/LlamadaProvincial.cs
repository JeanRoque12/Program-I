public class LlamadaProvincial : Llamada
{
    protected int franja {get; set;}
    public LlamadaProvincial(string numOrigen, string numDestino, double duracion, int franja)
    {
        this.numOrigen = numOrigen;
        this.numDestino = numDestino;
        this.duracion = duracion;
        this.franja = franja;
        switch (this.franja) 
        {
            case 1:
                this.precio = 0.20;
                break;
            case 2:
                this.precio = 0.25;
                break;
            case 3:
                this.precio = 0.30;
                break;
            default:
                this.precio = 0.00;
                break;
        }
        this.costoLlamada = this.precio*this.duracion;

    }  

}