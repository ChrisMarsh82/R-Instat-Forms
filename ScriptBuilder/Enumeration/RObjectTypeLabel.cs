using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptBuilder.Enumeration
{
    public enum RObjectTypeLabel
    {
        [Description("dataframe")]
        Dataframe = 0,
        [Description("column")]
        Column  = 1,
        [Description("graph")]
        Graph =2,
        [Description("table")]
        Table = 3,
        [Description("model")]
        Model = 4,
        [Description("structure")]
        StructureLabel = 5,
        [Description("summary")]
        Summary     = 6,

    }
}
