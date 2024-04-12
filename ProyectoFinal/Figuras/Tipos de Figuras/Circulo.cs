public class Circulo : Bidimensional
{
    protected double radio;
    protected double circumferencia;
    public Circulo(string tipo, double radio)
    {
        this.tipo = tipo;
        this.radio = radio;
        numeroCaras = null;
        numeroVertices = 0;
        numeroAristas= 0;
        circumferencia = 2*Math.PI*radio;
        perimetro = circumferencia;
        area = Math.PI*Math.Pow(radio, 2);
    }
    public double GetRadio() => this.radio;
    public double GetCircunferencia() => this.circumferencia;
}