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
            WorkFlowControlBase? formDefinition =  GetFormClass((FormList)id);
            form.Controls = (IEnumerable<Control>?)formDefinition.Controls;
      

            return form;
        }
    }
}
