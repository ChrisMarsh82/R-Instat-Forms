using webapi.Enumeration;

namespace webapi.Model
{
    public class Control
    {
        public int Id { get; set; }
        public ControlType ControlType { get; set; }
        public string? Label { get; set; }
        public string? Help { get; set; }

        //not implemented as enabled should be used.
      //  public int? VisibleControlLink { get; set; } //Can only add control type that are boolean. and only link it to true

        /// <summary>
        /// used for enabled and visible and also columns linking to dataframe
        /// </summary>
        public int? ControlLink { get; set; } //Can only add control type that are boolean. and only link it to true

        public int? Min { get; set; }
        public int? Max { get; set; }

        public string? DefaultValue { get; set; }

        public List<string>? PossibleValues { get; set; }    

        public List<Control>? Controls { get; set; }    


        //may need to add value or this could be done somewhere else

    }
}
