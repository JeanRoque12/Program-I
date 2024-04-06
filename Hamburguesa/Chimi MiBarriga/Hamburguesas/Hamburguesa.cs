/*
La clase abstracta de las hamburguesas. Los valores dependen
del tipo, pero todas comparten las mismas variables. La lista
de ingredientes depende del tipo de hamburguesa, y cada instancia de
cualquier hamburguesa comienza con ningun ingrediente adicional. Se pueden
agregar ingredientes de la lista de "ingedientesAdicionales". Algunos tipos
de hamburguesas pueden acceder al metodo de agregar ingredientes adicionales.
*/

public abstract class Hamburguesa
{
    protected bool bebida { get; set; }
    protected bool papasFritas { get; set; }
    protected string tipo { get; set; }
    protected List<Ingredientes> ingredientesAdicionales = new();
    protected List<Ingredientes> ingredientesUtilizados = new();
    protected string pan { get; set; }
    protected string carne { get; set; }
    protected double precioBase { get; set; }
    protected double precioTotal { get; set; }

    public virtual void AnadirIngredientes()
    /*
    Este metodo imprime las posibles opciones de ingredientes adicionales a elegir y permite al usuario elegir. 
    Una vez elegida un ingrediente, es es agregado a la lista de ingredientes utilizados y lo elimina de las opciones a elegir.
    Luego se le pregunta al usuario si quiere agregar otro ingrediente.
    */
    {
        Console.WriteLine("\n");

        for (int i = 0; i < ingredientesAdicionales.Count(); i++)
            Console.WriteLine($"{i+1}) {ingredientesAdicionales[i].GetNombreIngrediente()}");
        Console.Write("\nCual ingrediente deseas agregar? ");

        Ingredientes ingrediente = ingredientesAdicionales[Convert.ToInt32(Console.ReadLine()) - 1];
        ingredientesUtilizados.Add(ingrediente);
        ingredientesAdicionales.Remove(ingrediente);
        this.precioTotal += ingrediente.GetPrecioIngrediente();

        Console.Write("Se agrego el ingrediente. Presione ENTER para continuar: ");
        Console.ReadLine();

        Console.Write("Desea agregar otro ingrediente (Y/N)? ");
        string decision = Console.ReadLine().ToLower();
        Console.WriteLine();

        if (decision == "y")
            AnadirIngredientes();
        else if (decision == "n")
            return;


    }
    public virtual void MostrarIngredientes()
    {
        Console.WriteLine("Ingredientes Adicionales: ");
        foreach (Ingredientes ingrediente in ingredientesUtilizados)
        {
            Console.WriteLine($"{ingrediente.GetNombreIngrediente()} - {ingrediente.GetPrecioIngrediente()}");
        }
        Console.WriteLine("");
    }
    public List<Ingredientes> GetIngredientes() => ingredientesUtilizados;
    public string GetTipoHamburguesa() => tipo;
    public string GetTipoPan() => pan;
    public string GetTipoCarne() => carne;
    public double GetPrecioBase() => precioBase;
    public double GetPrecioTotal() => precioTotal;
    public void Bebida()
    {
        if (bebida)
            Console.WriteLine("Esta hamburguesa trae bebida.");
        else
            Console.WriteLine("Esta hamburguesa no trae bebida.");
    }

    public void Papas()
    {
        if (papasFritas)
            Console.WriteLine("Esta hamburguesa trae papas fritas.");
        else
            Console.WriteLine("Esta hamburguesa no trae papas fritas.");
    }

    public void Factura()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Factura:\n");
        Console.WriteLine($"Precio base de la Hamburguesa {this.tipo}: {this.precioBase}\n");
        MostrarIngredientes();
        Bebida();
        Papas();
        Console.Write("\nPresion ENTER para ver el precio total: ");
        Console.ReadLine();
        Console.WriteLine(String.Format("Precio total a pagar: {0:C0}\n", Convert.ToDecimal(this.precioTotal)));
        Console.Write("Presione ENTER para continuar: ");
        Console.ReadLine();
    }
}