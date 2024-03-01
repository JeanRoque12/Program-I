class Mamifero : Mascota {
    protected string? pelaje {get; set;}
    
    public Mamifero(string Pelaje, string orden) {
        this.clase = "Mammalia";
        this.orden = orden;
        this.pelaje = Pelaje;
    }
    public string? GetPelaje() {
        return this.pelaje;
    }
    public void SetPelaje(string pelaje) {
        this.pelaje = pelaje;
    }
    public override void Sonido() {
        Console.WriteLine("Este mamifero hace sonido...");
    }

}