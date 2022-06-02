
namespace Full_GRASP_And_SOLID
{
    public interface IPrinter<T> where T : IPrintable
    {
         void Print(T printable);
    }
}