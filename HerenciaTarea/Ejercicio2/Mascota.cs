class Mascota {
    protected string nivelDeFelicidad {get; set;}
    protected string nivelDeSalud {get; set;}
    protected string? tamano {get; set;}
    protected string clase {get; set;}
    protected string orden {get; set;}
    protected string especie {get; set;}
    public Mascota() {
        this.nivelDeFelicidad = "Felicidad nivel normal.";
        this.nivelDeSalud = "Salud nivel normal.";
        this.tamano = null;
    }
    public string? GetFelicidad() {
        return this.nivelDeFelicidad;
    }
    public string? GetSalud() {
        return this.nivelDeSalud;
    }
    public void SetFelicidad(string nuevaFelicidad) {
        this.nivelDeFelicidad = nuevaFelicidad;
    }
    public void SetSalud(string nuevaSalud) {
        this.nivelDeSalud = nuevaSalud;
    }
    public string? GetTamano(){
        return this.tamano;
    }
    public void SetTamano(string valorTamano) {
        this.tamano = valorTamano;
    }
    public string GetClase() {
        return this.clase;
    }
    public void SetClase(string clase) {
        this.clase = clase;
    }
    public string GetOrden() {
        return this.orden;
    }
    public void SetOrden(string orden) {
        this.orden = orden;
    }
    public string GetEspecie() {
        return this.especie;
    }
    public void SetEspecie(string especia) {
        this.especie = especie;
    }
    public virtual void Sonido() {
        Console.WriteLine("Esta mascota hace un sonido...");
    }
}
