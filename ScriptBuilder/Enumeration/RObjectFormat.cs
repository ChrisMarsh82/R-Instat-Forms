using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptBuilder.Enumeration
{
    public enum RObjectFormat
    {
        [Description("image")]
        Image = 1,
        [Description("text")]
        Text = 2,
        [Description("html")]
        Html = 3
    }
}
