using FactoryMethod;




CardPaymentCreator cardcreator = new CardPaymentCreator();
CashPaymentCreator cashCreator = new CashPaymentCreator();



IPayment payment3 = cardcreator.CreatePayment();
payment3.Pay();

IPayment payment4 = cashCreator.CreatePayment();
payment4.Pay();

IPayment payment5 = cashCreator.CreatePayment();
payment5.Pay();