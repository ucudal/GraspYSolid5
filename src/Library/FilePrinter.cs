using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter<T> : IPrinter<T> where T : IPrintable
    {
        string path;

        public FilePrinter(string path)
        {
            this.path = path;
        }

        public void Print(T printable)
        {
            File.WriteAllText(this.path, printable.GetTextToPrint());
        }
    }
}