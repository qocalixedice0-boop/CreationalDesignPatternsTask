

using AbstractFactory.Interfaces;

namespace AbstractFactory;

internal class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Windows Button rendered");
    }
}
