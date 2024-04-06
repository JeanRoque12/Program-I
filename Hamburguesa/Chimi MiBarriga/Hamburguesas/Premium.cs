public class Premium : Hamburguesa
{
    public Premium(string pan, string carne)
    {
        bebida = true;
        papasFritas = true;
        tipo = "Premium";
        precioBase = 130;
        this.pan = pan;
        this.carne = carne;
        precioTotal = precioBase;

        

    }
    public override void AnadirIngredientes() 
        {
            Console.WriteLine("A la hamburguesa premium no se le puede agregar ingredientes.");
            return;
        }
     public override void MostrarIngredientes()
    {
        Console.WriteLine("La hamburguesa premium no contiene ingredientes adicionales.");
        return;
    }
}