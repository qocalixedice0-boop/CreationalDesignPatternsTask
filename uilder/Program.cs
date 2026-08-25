using Builder;

Computer computer = new ComputerBuilder()
    .SetCPU("Intel")
    .SetRAM("12GB")
    .SetStorage("512GB")
    .Build();

Console.WriteLine(computer.CPU);
Console.WriteLine(computer.RAM);
Console.WriteLine(computer.Storage);