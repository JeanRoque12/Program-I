class Perro : Mamifero {
    public Perro(string Pelaje, string especie) : base("", "Carnivoro") {
        this.pelaje = Pelaje;
        this.clase = "Mammalia";
        this.orden = "Carnivoro";
        this.especie = especie;
    }
    public override void Sonido() {
        Console.WriteLine("Woof Woof!");
    }
}