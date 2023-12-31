﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Net;
using webapi.Builder;
using webapi.Enumeration;
using webapi.Extension;
using webapi.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace webapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RInstatFormController : ControllerBase
    {

        [HttpGet("allforms")]
        public IEnumerable<PartialForm> GetAllForms()
        {
            List<PartialForm> allForms = new();
            foreach (int i in Enum.GetValues(typeof(FormList)))
            {
                allForms.Add(new PartialForm
                {
                    Id = i,
                    Name = ((FormList)i).GetDescription(),
                    Description = "all the same"
                });
            }
            return allForms;
        }

        [HttpGet("allforms/{id}")]
        public Form GetForms(int id)        
        {
            FormBuilder formbuilder = new FormBuilder();
            return formbuilder.GetForm(id);
        }

        [HttpGet("test")]
        public Form GetTest()
        {
            FormBuilder formbuilder = new FormBuilder();
            return formbuilder.GetForm(1);
        }

        [HttpPost("rscript")]
        public ActionResult<string> GetRScript( FormValue formValue)
        {
            FormBuilder formbuilder = new();
            string rScript = formbuilder.GetRScriptFromForm(formValue.id, formValue.ControlValues);
            return Ok(rScript);
        }




    }
}
