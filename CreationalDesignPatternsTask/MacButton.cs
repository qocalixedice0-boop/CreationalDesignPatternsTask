

using AbstractFactory.Interfaces;

namespace AbstractFactory;

internal class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Mac Button rendered");
    }
}
