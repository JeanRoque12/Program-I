Console.Write("Ingrese el tipo de bus: ");
int tipoBus = Convert.ToInt16(Console.ReadLine()); // Se ingresa un numero que represnta el tipo de bus

Console.Write("Ingrese el numero de pasajeros: ");
int numeroDePasajeros = Convert.ToInt32(Console.ReadLine()); // Se ingresa el numero de pasajeros

Bus bus;

switch (tipoBus) //Se asigna a la variable bus la instancia del tipo de bus
{
    case 1:
        bus = new GuaGua(numeroDePasajeros);
        break;
    case 2:
        bus = new BusNormal(numeroDePasajeros);
        break;
    case 3:
        bus = new BusPremium(numeroDePasajeros);
        break;
    default:
        bus = new GuaGua(numeroDePasajeros);
        break;
}

Console.Write("Desde donde inicia el viaje: ");
string? origen = Console.ReadLine();
Console.Write("Cual es el destino: ");
string? destino = Console.ReadLine();

string ruta = $"{origen} - {destino}";

Console.Write("Cual es la distancia de esta ruta: ");
double distancia = Convert.ToDouble(Console.ReadLine());

Viaje viaje = new Viaje(bus, ruta, distancia);

Console.WriteLine($@"

Tipo de Bus: {viaje.GetBus().GetTipoBus()}
Cantidad de Pasajeros: {viaje.GetBus().GetNumeroPasajeros()}
Ruta: {viaje.GetRuta()}
Distancia del viaje: {viaje.GetDistancia()}
Precio por pasajero: {viaje.GetPrecioDelViaje()}
Ganancias total del viaje: {viaje.GetGananciaTotal()}

");
