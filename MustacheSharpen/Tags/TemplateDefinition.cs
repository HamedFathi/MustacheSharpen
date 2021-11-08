﻿using System.Collections.Generic;
using System.IO;
using MustacheSharpen;

// ReSharper disable All 
namespace MustacheSharpen
{
    public class TemplateDefinition : InlineTagDefinition
    {
        public TemplateDefinition()
                    : base("template")
        {
        }

        protected override IEnumerable<TagParameter> GetParameters()
        {
            return new[] { new TagParameter("param") { IsRequired = true } };
        }

        public override void GetText(TextWriter writer, Dictionary<string, object> arguments, Scope context)
        {
            writer.Write(arguments["param"]);
        }
    }
}
