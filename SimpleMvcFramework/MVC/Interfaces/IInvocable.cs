using SimpleMvsFramework.MVC.Interfaces;

namespace SimpleMvcFramework.MVC.Interfaces
{
    public interface IInvocable : IRedirectable
    {
        string Invoke();
    }
}
