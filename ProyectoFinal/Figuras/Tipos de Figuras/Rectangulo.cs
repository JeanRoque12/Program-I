public class Rectangulo : Bidimensional
{
    protected double _base;
    protected double altura;
    public Rectangulo(string tipo, double _base, double altura)
    {
        this.tipo = tipo; 
        this.numeroCaras = null;
        this.numeroVertices = 4;
        this.numeroAristas = 4;
        this._base = _base;
        this.altura = altura;
        this.area = _base*altura;
        this.perimetro = 2*_base + 2*altura;

    }
    public double? GetBase() => _base;
    public double? GetAltura() => altura;
}