using Singleton;

Console.WriteLine("Hello, World!");
Logger logger1 = Logger.Instance;
Logger logger2 = Logger.Instance;

Console.WriteLine(logger1 == logger2);