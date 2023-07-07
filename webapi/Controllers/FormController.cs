using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.Builder;
using webapi.Enumeration;
using webapi.Extension;
using webapi.Model;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<PartialForm> GetAllForms()
        {
            List<PartialForm> allForms = new();
            foreach (int i in Enum.GetValues(typeof(FormList)))
            {
                allForms.Add(new PartialForm
                {
                    Id = i,
                    Name = ((FormList)i).GetDescription()
                });
            }
            return allForms;
        }

        [HttpGet]
        public Form GetForm(int id) 
        {
            FormBuilder formbuilder = new FormBuilder();
            return formbuilder.GetForm(id);
        }

        [HttpGet]
        public String? GetRScript() { return null; } //This will need a collection of values passed to it

    }
}
