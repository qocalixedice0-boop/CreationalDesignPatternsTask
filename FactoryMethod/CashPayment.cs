
namespace FactoryMethod;

internal class CashPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paying with cash.");
    }
}
