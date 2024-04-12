public class TrianguloRecto : Bidimensional {
    protected double _base {get; set;}
    protected double altura {get; set;}
    protected double hipotenusa {get; set;}

    public TrianguloRecto(string tipo, double _base, double altura) {
        this.tipo = tipo;
        this.numeroCaras = null;
        this.numeroAristas = 3;
        this.numeroVertices = 3;
        this._base = _base;
        this.altura = altura;
        this.hipotenusa = Math.Sqrt(Math.Pow(_base, 2) + Math.Pow(altura, 2));
        this.area = 0.5*_base*altura;
        this.perimetro = hipotenusa + _base + altura;
    }
    public double? GetBase() {
        return _base;
    }
    public double? GetAltura() {
        return altura;
    }
    public double? GetHipotenusa() => this.hipotenusa;

    
}