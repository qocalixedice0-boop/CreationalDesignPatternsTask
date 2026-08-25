

namespace FactoryMethod;

internal class CashPaymentCreator : PaymentCreator
{
    public override IPayment CreatePayment()
    {
        return new CashPayment();
    }

}
