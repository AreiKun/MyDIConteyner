using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDIConteyner
{
    class Conteiner: IConteiner
    {
        private readonly Dictionary<Type, Type> types = new Dictionary<Type, Type>();

        public void Register<TInterface, TImplementation>() where TImplementation : TInterface
        {
            types[typeof(TInterface)] = typeof(TImplementation);
        }

        public TInterface Create<TInterface>()
        {
            return (TInterface)Create(typeof(TInterface));
        }

        private object Create(Type type)
        {
            //конструктор по умолчанию с помощью отражения
            var concreteType = types[type];
            var defaultConstructor = concreteType.GetConstructors()[0];
            //Проверяем наличие метода в конструкторе
            var defaultParams = defaultConstructor.GetParameters();
            //Создаём экземпляр
            var parameters = defaultParams.Select(param => Create(param.ParameterType)).ToArray();

            return defaultConstructor.Invoke(parameters);
        }
    }
}
