
using AbstractFactory.Interfaces;

namespace AbstractFactory;

internal class MacCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Mac Checkbox rendered");
    }
}
