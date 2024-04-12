public class Esfera : Tridimensional
{
    protected double radio;
    public Esfera(string tipo, double radio)
    {
        this.tipo = tipo;
        this.radio = radio;
        this.numeroAristas = 0;
        this.numeroCaras = 0;
        this.numeroVertices = 0;
        this.volumen = 1.333333333 * Math.PI * Math.Pow(radio, 3);
        this.areaSuperficial = 4 * Math.PI * Math.Pow(radio, 2);
    }
    public double GetRadio() => this.radio;
}