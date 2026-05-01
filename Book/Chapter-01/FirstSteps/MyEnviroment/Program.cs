namespace MyEnviroment;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Environment.CurrentDirectory);
        Console.WriteLine(Environment.OSVersion.VersionString);
        Console.WriteLine("Namespace: {0}", typeof(Program).Namespace);
        Console.WriteLine(format: "Value is {0}.", arg0: 19.8);
    }
    
}
