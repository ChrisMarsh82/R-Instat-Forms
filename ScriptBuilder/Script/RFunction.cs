using ScriptBuilder.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptBuilder.Script
{
    public class RFunction
    {
        private string _assignment = "";
        private string _command = "command not assigned";
        private string _parameters = "";

        public string GetAssigned()
        {
            return _assignment;
        }

        public void AddParameter(string param, string value, bool addQuotes = false)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (!string.IsNullOrEmpty(_parameters))
                {
                    _parameters += ", ";
                }
                if (addQuotes)
                {
                    value = "\"" + value + "\"";
                }
                _parameters += param + "=" + value;
            }
        }

        public void AddParameter(string param, List<string> values, bool addQuotes = false)
        {
            string stringValue = "";
            bool first = true;
            if (values.Count > 1)
            {
                stringValue = "c(";
                foreach (var value in values)
                {
                    if (!first)
                    {
                        stringValue += ", ";
                    }
                    if (addQuotes)
                    {
                        stringValue += "\"" + value + "\"";
                    }
                    else
                    {
                        stringValue += value;
                    }
                    first = false;
                }
                stringValue += ")";
            }
            else
            {
                if (addQuotes)
                {
                    stringValue = "\"" + values[0] + "\"";
                }
                else
                {
                    stringValue = values[0];
                }
            }
            AddParameter(param, stringValue);
        }

        public void AddParameter(string param, RFunction rFunction)
        {
            AddParameter(param, rFunction.ToScript());
        }

        public void AddParameter(string param, bool value)
        {
            AddParameter(param, value.ToString());
        }

        public void AddParameter(string param, int value)
        {
            AddParameter(param, value.ToString());
        }

        public void SetBasicRCommand(string command)
        {
            _command = command;
        }

        public void SetPackageRCommand(string package, string command)
        {
            _command = package + "::" + command;
        }

        public void SetDataBookCommand(string command)
        {
            _command = RCodeConstant.DataBookName + "$" + command;
        }

        public void SetAssignTo(string assign)
        {
            _assignment = assign;
        }

        public void AddParameterAsPlus()
        {
            // Your implementation here
        }

        public string ToScript()
        {
            if (!string.IsNullOrEmpty(_assignment))
            {
                _assignment += " <- ";
            }
            return _assignment + _command + "(" + _parameters + ")";
        }

        public void SetAssignTo(object getParameter)
        {
            throw new NotImplementedException();
        }

        //public void AddParameter(string v, object getRFunction)
        //{
        //    throw new NotImplementedException();
        //}

        //public void AddParameter(string v, object getParameter)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

