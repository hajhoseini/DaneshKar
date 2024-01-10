namespace Delegate_Action_Sample.Simple;

public class PrintMethod
{
    public void PrintA(string text)
    {
        Console.WriteLine(text);
    }

    public void PrintB(string text)
    {
        Console.WriteLine("Begin" + text + "End");
    }
}

public class PrintHandler
{
    public void Print(PrintTypeEnum printType)
    {
        string text = "aaaaaaaa";

        PrintMethod printMethod = new();

        if (printType == PrintTypeEnum.TypeA)
            printMethod.PrintA(text);
        else if (printType == PrintTypeEnum.TypeB)
            printMethod.PrintB(text);
        
    }
}
