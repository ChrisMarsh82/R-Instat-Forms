using webapi.Enumeration;
using webapi.Model;

namespace webapi.ValueControl
{
    public class TextSelector : ControlBase
    {
        private string v;

        public TextSelector(int id,string Label,string DefaultValue)
        {
            ControlModel = new Control
            {
                Id = id,
                Label = Label,
                ControlType = ControlType.TextSelector,
                Help = "Enter a string",
                DefaultValue = DefaultValue,

            };
        }



    }
}
