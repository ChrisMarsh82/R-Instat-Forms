using ScriptBuilder.Script;
using webapi.Enumeration;
using webapi.Interface;
using webapi.Model;

namespace webapi.FunctionControl
{
    public class MultipleColumnSelector : ControlBase, IRFunctionControl
    {
        private DataFrameSelector _dataframeSelector;

        public MultipleColumnSelector(int id, string Label,DataFrameSelector dataframeSelector)
        {
            ControlModel = new Control
            {
                Id = id,
                Label = Label,
                ControlType = ControlType.MultipleColumnSelector,
                Help = "Select the column you would like to use",
                ControlLink = dataframeSelector.ControlModel.Id,               

            };
            _dataframeSelector = dataframeSelector;
        }






        internal RFunction GetRFunction()
        {
            RFunction rFunction = new RFunction();
            rFunction.SetDataBookCommand("get_columns_from_data");
            rFunction.AddParameter("data_name", _dataframeSelector.GetParameterWithQuotes());
            rFunction.AddParameter("col_names", GetParameterWithQuotes());
            return rFunction;
        }

        RFunction IRFunctionControl.GetRFunction()
        {
            throw new NotImplementedException();
        }
    }
 
}
