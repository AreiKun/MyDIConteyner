
namespace MyDIConteyner
{
    interface IConteiner
    {        
        public void Register<TInterface, TImplementation>() where TImplementation : TInterface;
        TInterface Create<TInterface>();
    }
}
