class Colibri : Ave {
    public Colibri(string tipoDePico, string especie) : base("", "Omnivoro") {
        this.tipoDePico = tipoDePico;
        this.clase = "Aves";
        this.orden = "Omnivoro";
        this.especie = especie;
    }
    public override void Sonido() {
        Console.WriteLine("Pio Pio!");
    }
}