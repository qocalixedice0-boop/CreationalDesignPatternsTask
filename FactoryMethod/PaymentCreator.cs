

namespace FactoryMethod;

internal abstract class PaymentCreator
{
    //paymentin yaradilmasini subclasslara hevale edir
    public abstract IPayment CreatePayment();
}
