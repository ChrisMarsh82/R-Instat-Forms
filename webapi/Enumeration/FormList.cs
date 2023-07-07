using System.ComponentModel;

namespace webapi.Enumeration
{
    public enum FormList
    {
        [Description("One Variable Summary")]
        OneVariableSummarise = 0,
        [Description("One Variable Custom Summary")]
        OneVariableSummariseCustom = 1,
        [Description("One Variable Skim Summary")]
        OneVariableSummariseSkim = 2

    }
}
