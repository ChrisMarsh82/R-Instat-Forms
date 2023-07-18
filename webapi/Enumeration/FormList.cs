using System.ComponentModel;

namespace webapi.Enumeration
{
    public enum FormList
    {
        [Description("One Variable Summary")]
        OneVariableSummarise = 1,
        [Description("One Variable Custom Summary")]
        OneVariableSummariseCustom = 2,
        [Description("One Variable Skim Summary")]
        OneVariableSummariseSkim = 3

    }
}
