
public class IB : IBanking
{
    public void Deposit(Customer customer)
    {
        customer.Saldo += customer.Monto;
        Console.WriteLine("Deposito Exitoso en Internet Banking.");
    }

    public DetalleTransaccion detalleTransaccion(int IdMovimientos)
    {
        throw new NotImplementedException();
    }

    public int Inquiere(int CostumerID)
    {
        throw new NotImplementedException();
    }

    public int Inquiere(Customer customer)
    {
        throw new NotImplementedException();
    }

    public List<Movimientos> movimientos(Customer customer)
    {
        throw new NotImplementedException();
    }

    public int Pago(Customer customer)
    {
        throw new NotImplementedException();
    }

    public void Withdraw(Customer customer)
    {
        customer.Saldo -= customer.Monto;
        Console.WriteLine("Retiro Exitoso en Internet Banking");
    }
}