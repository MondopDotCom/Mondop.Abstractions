using System;
using System.Collections.Generic;

namespace Mondop.Abstractions.IoC
{
    public interface IIoCModule
    {
        void Register(IIoCContainer container);

        List<Type> DependsOn { get; }
    }
}
