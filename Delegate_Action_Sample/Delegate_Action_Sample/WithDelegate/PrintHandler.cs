namespace Delegate_Action_Sample.WithDelegate;

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

public delegate void PrintDelegate(string text);

public class PrintHandler
{
    public PrintDelegate GetPrintMethod(PrintTypeEnum printType)
    {
        PrintMethod printMethod = new();

        if (printType == PrintTypeEnum.TypeA)
            return printMethod.PrintA;
        else if (printType == PrintTypeEnum.TypeB)
            return printMethod.PrintB;

        return printMethod.PrintA;
    }

    public void Print(PrintTypeEnum printType, PrintDelegate printMethod)
    {
        string text = "aaaaaaaa";
        printMethod(text);
    }
}
