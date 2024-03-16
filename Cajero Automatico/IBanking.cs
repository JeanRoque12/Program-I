public interface IBanking
{
    void Withdraw(Customer customer);
    void Deposit(Customer customer);
    int Inquiere (Customer customer);
    List<Movimientos> movimientos(Customer customer);
    DetalleTransaccion detalleTransaccion(int IdMovimientos);
    int Pago (Customer customer);

};
