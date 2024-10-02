using Laboratory6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Laboratory6
{
    [JsonConverter(typeof(NestedElementConverter))]
    public abstract class NestedElement : IPrototype<NestedElement>
    {
        public abstract NestedElement Clone();
    }
}
