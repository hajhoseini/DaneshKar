namespace Delegate_Action_Sample.WithAction;

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
    public Action<string> GetPrintMethod(PrintTypeEnum printType)
    {
        PrintMethod printMethod = new();

        if (printType == PrintTypeEnum.TypeA)
            return printMethod.PrintA;
        else if (printType == PrintTypeEnum.TypeB)
            return printMethod.PrintB;

        return printMethod.PrintA;
    }

    public void Print(PrintTypeEnum printType, Action<string> printMethod)
    {
        string text = "aaaaaaaa";
        printMethod(text);
    }
}
