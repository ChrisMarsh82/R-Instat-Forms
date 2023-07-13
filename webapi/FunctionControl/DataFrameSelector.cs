using ScriptBuilder.Script;
using System.Reflection.Metadata.Ecma335;
using webapi.Enumeration;
using webapi.Interface;
using webapi.Model;

namespace webapi.FunctionControl
{
    public class DataFrameSelector : ControlBase, IRFunctionControl
    {




        public DataFrameSelector(int id, string Label)
        {
            ControlModel = new Control
            {
                Id = id,
                Label = Label,
                ControlType = ControlType.DataframeSelector,
                Help = "Select the dataframe you would like to use",

            };
        }


        RFunction IRFunctionControl.GetRFunction()
        {
            RFunction rFunction = new RFunction();
            rFunction.SetDataBookCommand("get_data_frame");
            rFunction.AddParameter("data_name", GetParameterWithQuotes());
            return rFunction;
        }
    }
}
