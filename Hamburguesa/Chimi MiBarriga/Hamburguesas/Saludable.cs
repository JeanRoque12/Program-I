public class Saludable : Hamburguesa
{
    public Saludable()
    {
        bebida = false;
        papasFritas = false;
        tipo = "Saludable";
        precioBase = 70;
        pan = "Pan integral";
        carne = "Carne Org\u00E1nica";
        precioTotal = precioBase;

        ingredientesAdicionales.AddRange([
            new Calabaza(),
            new Cebolla(),
            new Champinones(),
            new Pimiento(),
            new Tofu(),
            new Zanahoria()
        ]);
    }
}