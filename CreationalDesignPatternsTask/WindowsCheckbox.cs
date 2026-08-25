

using AbstractFactory.Interfaces;

namespace AbstractFactory;

internal class WindowsCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Windows Checkbox rendered");
    }
}
