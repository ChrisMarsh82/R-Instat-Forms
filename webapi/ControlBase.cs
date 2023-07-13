using static System.Net.Mime.MediaTypeNames;
using webapi.Model;

namespace webapi
{
    public class ControlBase
    {
        public Control? ControlModel { get; set; }

        public bool IsMultiSelect { get; set; } = false;

        private List<string>? valueList;

        internal string GetParameter()
        {
            if (valueList.Count == 1)
            {
                return valueList[0];
            }
            else
            {
                string strTemp = "c(";
                for (int i = 0; i < valueList.Count; i++)
                {
                    if (i > 0)
                    {
                        strTemp += ",";
                    }
                    strTemp += valueList[i];
                }
                strTemp += ")";
                return strTemp;
            }

        }

        internal void AddValues(IEnumerable<string> values)
        {
            valueList = values.ToList() ?? new List<string>();

        }

        internal string GetParameterWithQuotes()
        {
            //ToDo may need to add c() to this 
            if (valueList.Count == 1)
            {
                return "\"" + valueList[0] + "\"";
            }
            else
            {
                string strTemp = "c(";
                for (int i = 0; i < valueList.Count; i++)
                {
                    if (i > 0)
                    {
                        strTemp += ",";
                    }
                    strTemp += "\"" + valueList[i] + "\""; 
                }
                strTemp += ")";
                return strTemp;
            }
        }

   


    }
}
