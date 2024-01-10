using Delegate_Action_Sample.WithDelegate;
using System;

namespace Delegate_Action_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            PrintTypeEnum printType = PrintTypeEnum.TypeA;

            #region Simple

            Delegate_Action_Sample.Simple.PrintHandler handler1 = new();
            handler1.Print(printType);

            #endregion

            #region WithDelegate

            Delegate_Action_Sample.WithDelegate.PrintHandler helper2 = new();
            PrintDelegate printMethod2 = helper2.GetPrintMethod(printType);
            helper2.Print(printType, printMethod2);

            #endregion

            #region WithAction

            Delegate_Action_Sample.WithAction.PrintHandler helper3 = new();
            Action<string> printMethod3 = helper3.GetPrintMethod(printType);
            helper3.Print(printType, printMethod3);

            #endregion
        }
    }
}