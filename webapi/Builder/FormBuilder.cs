using ScriptBuilder.Script;
using webapi.Enumeration;
using webapi.Model;
using webapi.WorkFlowControl;
using webapi.WorkFlowControl.Describe;

namespace webapi.Builder
{
    public class FormBuilder
    {

        private WorkFlowControlBase? GetFormClass(FormList form)
        {
            switch(form) 
            {
                case FormList.OneVariableSummarise:
                {
                        return new OneVariableSummarise();
                }
            }
            return null;
        }

        public Form GetForm(int id)
        {
            Form form = new Form();
            form.Id = id;
            form.Controls = new List<Control>();
            WorkFlowControlBase? formDefinition =  GetFormClass((FormList)id);
            foreach (ControlBase control in formDefinition.Controls)
            {
                form.Controls.Add(control.ControlModel);
            }
            form.Name = formDefinition.Name;
            form.Description = formDefinition.Description;

            return form;
        }

       

        internal string? GetRScriptFromForm(int id, IEnumerable<ControlValue>? controlValues)
        {
            WorkFlowControlBase? formDefinition = GetFormClass((FormList)id);
            RWorkFlow workFlowScript = formDefinition.PopulateScripts(controlValues);
            string justAString = string.Join(" ", workFlowScript.GetAllScripts());
            return justAString;
            
        }
    }
}
