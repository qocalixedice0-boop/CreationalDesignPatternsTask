

namespace FactoryMethod;

internal class CardPaymentCreator : PaymentCreator
{
    public override IPayment CreatePayment()
    {
        return new CardPayment();
    }

}
