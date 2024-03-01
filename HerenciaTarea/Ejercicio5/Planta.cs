class Planta {
    protected string colorHojas {get; set;}
    protected string altura {get; set;}
    protected bool frutos {get; set;}
    protected bool hojasCaidas {get; set;}

    protected string? TipoFruto;

    public Planta(string colorHojas, string altura, bool frutos) // Constructor
    {
        this.colorHojas = colorHojas;
        this.altura = altura;
        this.frutos = frutos;
        hojasCaidas = false;
    }

    public void CaenHojas() {
        this.hojasCaidas = true;
    }
    public void CrecenHojas() {
        this.hojasCaidas = false;
    }

    public string GetColorHojas() => this.colorHojas;
    public void SetColorHojas(string colorHojas) => this.colorHojas = colorHojas;
    public string GetAltura() => this.altura;
    public void SetAltura(string altura) => this.altura = altura;
    public bool GetHojasCaidas() => this.hojasCaidas;
    public void SetHojasCaidas(bool hojasCaidas) => this.hojasCaidas = hojasCaidas;
    public string? GetTipoFruto() => TipoFruto;
    
}
