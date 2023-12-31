﻿using ScriptBuilder.Constant;
using ScriptBuilder.Enumeration;
using ScriptBuilder.Extenstion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptBuilder.Script
{
    public class RWorkFlow
    {
        private RFunction? _preScript = null;
        private RFunction? _script;
        private string? _objectTypeLabel; // RObjectTypeLabel
        private string? _objectFormat; // RObjectFormat
        private bool _asFile;
        private bool _runAddAndGetObjectScripts = false;
        private string? _data_name;

        public RFunction PreScript
        {
            get { return _preScript; }
            set { _preScript = value; }
        }

        public RFunction Script
        {
            get { return _script; }
            set { _script = value; }
        }

        private string GetDatabookAddObjectScript()
        {
            RFunction rFunction = new RFunction();
            rFunction.SetDataBookCommand("add_object");
            rFunction.AddParameter("data_name", _data_name, true);
            rFunction.AddParameter("object_name",   _script?.GetAssigned(), true);
            rFunction.AddParameter("object_type_label", _objectTypeLabel, true);
            rFunction.AddParameter("object_format", _objectFormat, true);
            rFunction.AddParameter("object", _script?.GetAssigned());
            return rFunction.ToScript();
        }

        private string GetDatabookGetObjectScript()
        {
            RFunction rFunction = new RFunction();
            rFunction.SetDataBookCommand("get_object_data");
            rFunction.AddParameter("data_name", _data_name, true);
            rFunction.AddParameter("object_name", _script?.GetAssigned(), true);
            rFunction.AddParameter("as_file", _asFile);
            return rFunction.ToScript();
        }

        private bool IsCleanUpNeeded()
        {
            return ((_preScript != null) && (_preScript.GetAssigned() != "")) || (_script.GetAssigned() != "");
        }

        private List<string> GetAllAssignedObjects()
        {
            List<string> allAssigned = new List<string>();
            if ((_preScript != null) && _preScript.GetAssigned() != "")
            {
                allAssigned.Add(_preScript.GetAssigned());
            }
            if (_script?.GetAssigned() != "")
            {
                allAssigned.Add(_script.GetAssigned());
            }
            return allAssigned;
        }

        private string GetCleanUpScript()
        {
            RFunction rFunction = new RFunction();
            rFunction.SetBasicRCommand("rm");
            rFunction.AddParameter("list", GetAllAssignedObjects(),true);
            return rFunction.ToScript();
        }

        public List<string> GetAllScripts()
        {
            List<string> scripts = new List<string>();
            if (PreScript != null)
            {
                scripts.Add(PreScript.ToScript());
            }
            scripts.Add(Script.ToScript());
            if (_runAddAndGetObjectScripts)
            {
                scripts.Add(GetDatabookAddObjectScript());
                scripts.Add(GetDatabookGetObjectScript());
            }
            if (IsCleanUpNeeded())
            {
                scripts.Add(GetCleanUpScript());
            }
            return scripts;
        }

        public void SetDatabookObjectLog(string dataName, RObjectTypeLabel objectTypeLabel, RObjectFormat objectFormat, bool asFile)
        {
            _data_name = dataName;
            _objectTypeLabel = objectTypeLabel.GetDescription();
            _objectFormat = objectFormat.GetDescription();
            _asFile = asFile;
            _runAddAndGetObjectScripts = true;
        }
    }
}
