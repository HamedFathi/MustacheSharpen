// ReSharper disable All 
namespace MustacheSharpen
{
    public interface IArgument
    {
        string GetKey();

        object GetValue(Scope keyScope, Scope contextScope);
    }
}
