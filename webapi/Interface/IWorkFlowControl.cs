using ScriptBuilder.Script;
using webapi.FunctionControl;
using webapi.Model;
using webapi.ValueControl;

namespace webapi.Interface
{
    public interface IWorkFlowControl
    {
        void CreateAllSelectors();


        void AddValuesToSelectors(List<ControlValue> controlValues);


        public RWorkFlow PopulateScripts(List<ControlValue> controlValues);
    }
}
