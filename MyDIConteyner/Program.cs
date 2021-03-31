
namespace MyDIConteyner
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Conteiner();

            container.Register<IWelcom, Welcom>();
            container.Register<IWriter, ConsoleWriter>();

            var welcomer = container.Create<IWelcom>();
            welcomer.HelloTo("World");            
        }
    }
}
