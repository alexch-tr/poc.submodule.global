using POC.SubModule.Model1;

namespace POC.SubModule.Global;

class Program
{
    static void Main(string[] args)
    {
        var class1 = new Class1();
        var result = class1.Add(4, 5);
        Console.WriteLine(result);
    }
}