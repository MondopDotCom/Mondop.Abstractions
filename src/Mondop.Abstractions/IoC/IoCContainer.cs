using System;
using System.Collections.Generic;

namespace Mondop.Abstractions.IoC
{
    public interface IIoCContainer
    {
        void Register<TService, TImplementation>() where TService: class where TImplementation: class, TService;
        void RegisterSingleton<TService, TImplementation>() where TService: class where TImplementation: class, TService;
        void Register<TService>() where TService: class;
        void RegisterCollection<TService>(IEnumerable<Type> implementations) where TService : class;
    }
}
