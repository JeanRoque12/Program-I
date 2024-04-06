/*
La clase abstracta de ingredientes solo contiene las variables del nombre del ingrediente
y el precio adicional a pagar al agregarlo a la hamburguesa.
*/

public abstract class Ingredientes
{
    protected string nombre{get; set;}
    protected double precio {get; set;}

    public double GetPrecioIngrediente()
    {
        return this.precio;
    }
    public string GetNombreIngrediente()
    {
        return this.nombre;
    }


}