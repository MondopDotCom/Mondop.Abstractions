using System.Collections.Generic;

namespace Mondop.Abstractions.IoC
{
    public interface IIoCContainer
    {
        void Register<TService, TInterface>();
        void RegisterSingleton<TServie, TInterface>();
        void Register<TService, TInterface>(IEnumerable<TService> service);
    }
}
