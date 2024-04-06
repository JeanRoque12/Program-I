public class Clasica : Hamburguesa
{
    public Clasica(string pan, string carne)
    {
        bebida = false;
        papasFritas = false;
        tipo = "Cl\u00E1sica";
        precioBase = 80;
        this.pan = pan;
        this.carne = carne;
        precioTotal = 80;
        
        // ingredientesAdicionales.Add(new Bacon());
        // ingredientesAdicionales.Add(new Lechuga());
        // ingredientesAdicionales.Add(new Pepinillo());
        // ingredientesAdicionales.Add(new Tomate());

        ingredientesAdicionales.AddRange([
            new Bacon(),
            new Lechuga(),
            new Pepinillo(),
            new Tomate()
        ]);
    }
}