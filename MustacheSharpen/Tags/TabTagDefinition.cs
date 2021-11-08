using System.Collections.Generic;
using System.IO;
using MustacheSharpen;

// ReSharper disable All 
namespace MustacheSharpen
{
    public class TabTagDefinition : InlineTagDefinition
    {
        public TabTagDefinition()
                    : base("tab")
        {
        }

        public override void GetText(TextWriter writer, Dictionary<string, object> arguments, Scope context)
        {
            writer.Write("\t");
        }
    }
}
