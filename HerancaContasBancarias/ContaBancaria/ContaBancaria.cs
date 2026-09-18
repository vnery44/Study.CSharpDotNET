namespace HerancaContasBancarias.ContaBancaria;

internal class ContaBancaria
{
    protected double Saldo {  get; set; }
    public virtual void Depositar(double Valor)
    {
        Saldo += Valor;
    }
    public virtual void Sacar(double Valor)
    {
        Saldo -= Valor;
    }
    public virtual double CalcularSaldo()
    {
        return Saldo;
    }
}
