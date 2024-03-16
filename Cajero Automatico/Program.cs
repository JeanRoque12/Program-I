IBanking banking;
ATM _banking = new ATM();
Customer _customer = new Customer();

Console.WriteLine("Digite tipo de Canal: 1 = ATM, 2 = IB");
int canal = int.Parse(Console.ReadLine());

switch (canal)
{
    case 1:
        banking = new ATM();
        break;
    case 2:
        banking = new IB();
        break;
    default:
        Console.WriteLine("Canal Invalido.");
        break;
}
_customer.Montos = Convert.ToInt16(Console.ReadLine());
banking.Deposit(_customer);