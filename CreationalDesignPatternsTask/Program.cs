


using AbstractFactory;
using AbstractFactory.Interfaces;

IUIFactory factory1 = new WindowsFactory();


IButton button1 = factory1.CreateButton();
ICheckbox checkbox1 = factory1.CreateCheckbox();

button1.Render();
checkbox1.Render();


IUIFactory factory2= new MacFactory();
 

IButton button2= factory2.CreateButton();
ICheckbox checkbox2= factory2.CreateCheckbox();

button2.Render();
checkbox2.Render();