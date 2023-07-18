using ScriptBuilder.Script;
using ScriptBuilder.Enumeration;
using webapi.FunctionControl;
using webapi.ValueControl;
using webapi.Enumeration;
using webapi.Model;
using System.Collections.Generic;
using webapi.Interface;

namespace webapi.WorkFlowControl.Describe
{
    public class OneVariableSummarise : WorkFlowControlBase
    {
        private DataFrameSelector? dataframeSelector ;
        private MultipleColumnSelector? coloumnSelector ;
        private NumberSelector? maxLevelsSelector ;
        private TextSelector? summaryNameSelector;             

        public OneVariableSummarise() 
        {
            Name = "One Variable Summary";
            Description = "Here you can create a great summary with one variable";
            Id = (int)FormList.OneVariableSummarise;
            CreateAllSelectors();
        }

        protected override void CreateAllSelectors()
        {
            Controls = new List<ControlBase>();

            dataframeSelector = new DataFrameSelector(1,"Data Frame:");
            Controls.Add(dataframeSelector);

            coloumnSelector = new MultipleColumnSelector(2,"Variable(s) to Summarise", dataframeSelector);
            Controls.Add(coloumnSelector);

            maxLevelsSelector = new NumberSelector(3,"Maximum Factor Levels Shown", 12, 999);
            Controls.Add(maxLevelsSelector);

            summaryNameSelector = new TextSelector(4,"tablename", "last_summary");
            Controls.Add(summaryNameSelector);
        }

        protected override void AddValuesToSelectors(IEnumerable<ControlValue> controlValues)
        {
            foreach (ControlBase control in Controls)
            {
                control.AddValues(controlValues.First(x => x.Id == control.ControlModel.Id).Values);
            }
        }

        public override RWorkFlow PopulateScripts(IEnumerable<ControlValue> controlValues)
        {
            AddValuesToSelectors(controlValues);
            RWorkFlow RCode;
            RCode = new RWorkFlow();
            RCode.SetDatabookObjectLog(dataframeSelector.GetParameter(),RObjectTypeLabel.Summary, RObjectFormat.Text, true);
            RCode.Script = new RFunction();
            RCode.Script.SetBasicRCommand("summary");
            RCode.PreScript = dataframeSelector.GetRFunction();
            RCode.PreScript.SetAssignTo(dataframeSelector.GetParameter());
            RCode.Script.SetAssignTo(summaryNameSelector.GetParameter());
            RCode.Script.AddParameter("data", dataframeSelector.GetParameter());
            RCode.Script.AddParameter("object", coloumnSelector.GetRFunction());            
            RCode.Script.AddParameter("maxsum", maxLevelsSelector.GetParameter());
            RCode.Script.AddParameter("na.rm", "FALSE");
            return RCode;
        }
    }
}
