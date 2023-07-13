using webapi.Enumeration;
using webapi.Model;

namespace webapi.ValueControl
{
    public class NumberSelector : ControlBase
    {

        public NumberSelector(int id, string Label, int min, int max)
        {
            ControlModel = new Control
            {
                Id = id,
                Label = Label,
                ControlType = ControlType.NumberSelector,
                Help = "Select a value from: " + min.ToString() + " to: " +max.ToString(),
                Min = min,
                Max = max,
                DefaultValue = min.ToString(),

            };

        }





    }
}
