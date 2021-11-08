using System.Collections.Generic;
using System.IO;
using MustacheSharpen;
// ReSharper disable UnusedMember.Global

// ReSharper disable All 
namespace MustacheSharpen
{
    internal sealed class LengthTagDefinition : InlineTagDefinition
    {
        public LengthTagDefinition()
                    : base("length", true)
        {
        }

        public override void GetText(TextWriter writer, Dictionary<string, object> arguments, Scope contextScope)
        {
            if (contextScope.TryFind("length", out var length))
            {
                writer.Write(length);
            }
        }
    }
}
