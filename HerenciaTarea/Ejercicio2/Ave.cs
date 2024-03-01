class Ave : Mascota {
    protected string tipoDePico {get; set;}

    public Ave(string Pico, string orden) {
        this.clase = orden;
        this.orden = orden;
        this.tipoDePico = Pico;
    }

    public string GetTipoDePico() {
        return this.tipoDePico;
    }
    public void SetTipoDePico(string tipoDePico) {
        this.tipoDePico = tipoDePico;
    }

    public override void Sonido() {
        Console.WriteLine("Esta ave canta.");
    }

}