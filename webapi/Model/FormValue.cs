using Microsoft.AspNetCore.Mvc;

namespace webapi.Model
{
   /// <summary>
   /// [ModelBinder(BinderType = typeof(FormValueModelBinder))]
   /// </summary>
    public class FormValue
    {
        public int id { get; set; }
        public IEnumerable<ControlValue>? ControlValues { get; set; }
 //    public string? name { get; set; }   
    }
}
