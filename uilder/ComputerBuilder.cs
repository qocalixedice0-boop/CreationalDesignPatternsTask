

namespace Builder;

internal class ComputerBuilder
{
    private readonly Computer _computer;
    public ComputerBuilder()
    {
        _computer = new Computer();
    }
    public ComputerBuilder SetCPU(string cpu)
    {
        _computer.CPU=cpu;
        return this;   //eyni ComputerBuilder obyekti qaytarir
    }
    public ComputerBuilder SetRAM(string ram)
    {
        _computer.RAM=ram;
        return this;
    }
    public ComputerBuilder SetStorage(string storage)
    {
        _computer.Storage=storage;
        return this;
    }
    public Computer Build()
    {
        return _computer;
    }
}
