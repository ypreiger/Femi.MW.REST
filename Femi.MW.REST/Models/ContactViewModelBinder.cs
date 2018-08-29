using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Femi.MW.REST.Models
{
    public class ContactViewModelBinder : IModelBinder
    {
        Task IModelBinder.BindModelAsync(ModelBindingContext bindingContext)
        {
            var jsonString = bindingContext.ActionContext.HttpContext.Request.Query["contact"];
            ContactParams contact = JsonConvert.DeserializeObject<ContactParams>(jsonString);

            bindingContext.Result = ModelBindingResult.Success(contact);
            return Task.CompletedTask;
        }
    }
}
