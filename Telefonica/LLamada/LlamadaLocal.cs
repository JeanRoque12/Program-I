public class LlamadaLocal : Llamada
{
    public LlamadaLocal(string numOrigen, string numDestino, double duracion)
    {
        this.numOrigen = numOrigen;
        this.numDestino = numDestino;
        this.duracion = duracion;
        this.precio = 15;
        this.costoLlamada = this.duracion*precio;
    }
}
