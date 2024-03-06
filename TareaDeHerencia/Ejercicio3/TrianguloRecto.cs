class TrianguloRecto : Bidimensional {
    private double _base {get; set;}
    private double altura {get; set;}
    private double hipotenusa {get; set;}

    public TrianguloRecto(double _base, double altura) : base(3, 3) {
        this._base = _base;
        this.altura = altura;
        this.Calculo();
    }
    public double? GetBase() {
        return _base;
    }
    public void SetBase(double Base) {
        this._base = Base;
        this.Calculo();
    }
    public double? GetAltura() {
        return altura;
    }
    public void SetAltura(double altura) {
        this.altura = altura;
        this.Calculo();
    }
    public override void Calculo() {
        this.hipotenusa = Math.Sqrt((int)_base^2 + (int)altura^2);
        this.SetArea(0.5*_base*altura);
        this.SetParametro(_base + altura + hipotenusa);    
    }
    public override void SetArea(double Area)
    {
        return;
    }
    public override void SetParametro(double Parametro) {
        return;
    }
    public override void SetCaras(int caras)
    {
        return;
    }
    public override void SetAristas(int aristas)
    {
        return;
    }
    public override void SetVertices(int vertices)
    {
        return;
    }
}