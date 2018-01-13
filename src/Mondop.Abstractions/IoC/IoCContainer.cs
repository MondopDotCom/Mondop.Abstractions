namespace Mondop.Abstractions.IoC
{
    public interface IIoCContainer
    {
        void Register<TService, TImplementation>() where TService: class where TImplementation: class, TService;
        void RegisterSingleton<TService, TImplementation>() where TService: class where TImplementation: class, TService;
    }
}
