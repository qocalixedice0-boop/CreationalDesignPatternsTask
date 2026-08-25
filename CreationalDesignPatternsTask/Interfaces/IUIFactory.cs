

namespace AbstractFactory.Interfaces;

internal interface IUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}
