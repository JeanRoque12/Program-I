// See https://aka.ms/new-console-template for more information



Console.Write("Ingrese un numero: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese otro numero: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Operaciones operaciones = new Operaciones(num1, num2);


int[] resultados = [operaciones.Sumar(), operaciones.Restar(), operaciones.Multiplicar(), operaciones.Dividir()];
Console.WriteLine($"Resultados: {resultados}");