using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter<T> : IPrinter<T> where T : IPrintable
    {
        public void Print(T printable)
        {
            Console.WriteLine(printable.GetTextToPrint());
        }
    }
}