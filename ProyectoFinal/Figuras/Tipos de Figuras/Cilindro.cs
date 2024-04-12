public class Cilindro : Tridimensional
{
    protected double radio;
    protected double altura;
    public Cilindro(string tipo, double radio, double altura)
    {
        this.tipo = tipo;
        this.radio = radio;
        this.altura = altura;
        this.numeroAristas = 0;
        this.numeroCaras = 2;
        this.numeroVertices = 0;
        this.volumen = Math.PI * Math.Pow(radio, 2) * altura;
        this.areaSuperficial = 2*Math.PI * (Math.Pow(radio, 2) + altura*radio);
    }
    public double GetRadio() => this.radio;
    public double GetAltura() => this.altura;
}