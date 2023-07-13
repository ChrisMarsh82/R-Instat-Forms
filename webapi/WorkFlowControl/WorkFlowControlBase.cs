using ScriptBuilder.Script;
using webapi.Model;

namespace webapi.WorkFlowControl
{
    public abstract class WorkFlowControlBase
    {
        public List<ControlBase> Controls { get; set; }

        public string Name = "UNDEFINED";
        public string Description = "UNDEFINED";
        public int? Id = null;

        protected abstract void CreateAllSelectors();

        protected abstract void AddValuesToSelectors(IEnumerable<ControlValue> controlValues);

        public abstract  RWorkFlow PopulateScripts(IEnumerable<ControlValue> controlValues);


    }
}
