void Creacion()
{
    double _base;
    double altura;
    double lado;
    double radio;
    double anchura;
    double largo;
    string tipoFigura;

    Menu();
    int? opcion = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("");
    
    switch (opcion)
    {
        case 2: // Rectangulo
            tipoFigura = "Rectangulo";
            (_base, altura) = ElegirBaseYAltura(tipoFigura);
            ImprimirInfoBi(new Rectangulo(tipoFigura, _base, altura));
            Continuar();
            break;
        case 3: // Triangulo Recto
            tipoFigura = "Triangulo Recto";
            (_base, altura) = ElegirBaseYAltura(tipoFigura);
            ImprimirInfoBi(new TrianguloRecto(tipoFigura, _base, altura));
            Continuar();
            break;
        case 4: // Circulo
            tipoFigura = "Circulo";
            radio = ElegirRadioCirculo(tipoFigura);
            ImprimirInfoBi(new Circulo(tipoFigura, radio));
            Continuar();
            break;
        case 5: // Cubo
            tipoFigura = "Cubo";
            lado = ElegirLado(tipoFigura);
            ImprimirInfoTri(new Cubo(tipoFigura, lado));
            Continuar();
            break;
        case 6: // Rectangulo Prisma
            tipoFigura = "Rectangulo prisma";
            largo = ElegirLongitud("Largo", tipoFigura);
            anchura = ElegirLongitud("Anchura", tipoFigura);
            altura = ElegirLongitud("Altura", tipoFigura);
            ImprimirInfoTri(new RectanguloPrisma(tipoFigura, largo, anchura, altura));
            Continuar();
            break;
        case 7: // Cilindro
            tipoFigura = "Cilindro";
            radio = ElegirRadioCirculo(tipoFigura);
            altura = ElegirLongitud("Altura", tipoFigura);
            ImprimirInfoTri(new Cilindro(tipoFigura, radio, altura));
            Continuar();
            break;
        case 8: // Esfera
            tipoFigura = "Esfera";
            radio = ElegirRadioCirculo(tipoFigura);
            ImprimirInfoTri(new Esfera(tipoFigura, radio));
            Continuar();
            break;
        default: // Default tambien incluye al caso 1 de cuadrado
            tipoFigura = "Cuadrado";
            lado = ElegirLado(tipoFigura);
            ImprimirInfoBi(new Cuadrado(tipoFigura, lado));
            Continuar();
            break;
    }
}

Creacion(); // Inicio del programa





void Continuar()
{
    Console.WriteLine("");
    Console.WriteLine("Que desea hacer ahora? \n1) Crear otra figura\n2) Salir\n");
    switch (Convert.ToInt16(Console.ReadLine()))
    {
        case 1:
            Creacion();
            break;
        default:
            break;
    }
}

double ElegirLongitud(string parametro, string tipoFigura)
/* Busca las longitudes de los parametros de la tipoFigura. 
Estos parametros pueden ser lado, base, altura, radio, etc.
*/
{
    Console.Write($"{parametro} del {tipoFigura.ToLower()}: ");
    return Convert.ToDouble(Console.ReadLine());
}


double ElegirRadioCirculo(string tipoFigura)
{
    return ElegirLongitud("Radio", tipoFigura);
}

(double, double) ElegirBaseYAltura(string tipoFigura)
{
    return (ElegirLongitud("Base", tipoFigura), ElegirLongitud("Altura", tipoFigura));
}

double ElegirLado(string tipoFigura)
{
    return ElegirLongitud("Lado", tipoFigura);
}

void ImprimirForma(Figuras figura)
{
    Console.WriteLine($"Numero de vertices: {figura.GetVertices()}");
    Console.WriteLine($"Numero de aristas: {figura.GetAristas()}");
    Console.WriteLine($"Numero de caras: {figura.GetCaras()}");
}

void ImprimirAreaYPerimetro(Bidimensional figura)
{
    Console.WriteLine($"Perimetro: {figura.GetPerimetro():0.00}");
    Console.WriteLine($"Area: {figura.GetArea():0.00}");
}

void ImprimirVolumenYArea(Tridimensional figura)
{
    Console.WriteLine($"Volumen: {figura.GetVolumen():0.00}");
    Console.WriteLine($"Area superficial {figura.GetAreaSuperficial():0.00}");
}

void ImprimirInfoBi(Figuras figura)
{
    Console.WriteLine($"\nInformacion del {figura.GetTipo().ToLower()} (las medidas se dan en metros):");
    Console.WriteLine("");
    ImprimirForma(figura);
    ImprimirAreaYPerimetro((Bidimensional)figura);
}

void ImprimirInfoTri(Figuras figura)
{
    Console.WriteLine($"\nInformacion del {figura.GetTipo().ToLower()} (las medidas se dan en metros):");
    Console.WriteLine("");
    ImprimirForma(figura);
    ImprimirVolumenYArea((Tridimensional)figura);
}

void Menu()
{
    Console.WriteLine(@"

Bienvenidos a Crea Tu Figura. Puedes crear figuras bidimensionales y tridimensionales 
y calcularemos sus caracteristicas, como area o volumen. 

A continuacion, eliga el tipo de tipoFigura que desea crear: 

- Bidimensional
1) Cuadrado
2) Rectangulo
3) Triangulo Recto
4) Circulo

- Tridimensional
5) Cubo
6) Rectangulo Prisma
7) Cilindro
8) Esfera

*Si no elige ninguna opcion valida, se asumira que eligio un cuadrado.* 
");
}