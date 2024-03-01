class Manzano : Arbol {
    public Manzano(string colorHojas, string altura, string colorTronco, double espesorTronco) : base(colorHojas, altura, true, colorTronco, espesorTronco) {
        this.TipoFruto = "Manzana";
    }
}