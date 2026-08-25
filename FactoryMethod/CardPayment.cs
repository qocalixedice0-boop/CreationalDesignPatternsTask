
namespace FactoryMethod;

internal class CardPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paying with card.");
    }
}
