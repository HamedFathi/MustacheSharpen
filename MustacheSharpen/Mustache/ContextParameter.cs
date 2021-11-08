// ReSharper disable All 
namespace MustacheSharpen
{
    public sealed class ContextParameter
    {
        internal ContextParameter(string parameter, string argument)
        {
            Parameter = parameter;
            Argument = argument;
        }

        public string Parameter { get; }

        public string Argument { get; }
    }
}
