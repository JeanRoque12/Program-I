public class Cuadrado : Bidimensional
{
    protected double lado;

    public Cuadrado(string tipo, double lado)
    {
        this.tipo = tipo;
        this.numeroAristas = 4;
        this.numeroCaras = null;
        this.numeroVertices = 4;
        this.lado = lado;
        this.area = Math.Pow(lado, 2);
        this.perimetro= numeroAristas*lado;
    }
    public double GetLado() => this.lado;
}