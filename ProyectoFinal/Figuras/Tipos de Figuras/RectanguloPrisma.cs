public class RectanguloPrisma : Tridimensional
{
    protected double largo;
    protected double anchura;
    protected double altura;

    public RectanguloPrisma(string tipo, double largo, double anchura, double altura)
    {
        this.tipo = tipo;
        this.largo = largo;
        this.anchura= anchura;
        this.altura = altura;
        this.numeroAristas = 12;
        this.numeroCaras = 6;
        this.numeroVertices = 8;
        this.volumen = largo*anchura*altura;
        this.areaSuperficial = 2 * (anchura*altura + 2*largo*altura);
    }
    public double GetLargo() =>this.largo;
    public double GetAnchura() =>this.anchura;
    public double GetAltura() => this.altura;
}