namespace Mondop.Abstractions.IoC
{
    public interface IIoCContainer
    {
        void Register<TService, TInterface>();
        void RegisterSingleton<TServie, TInterface>();
    }
}
