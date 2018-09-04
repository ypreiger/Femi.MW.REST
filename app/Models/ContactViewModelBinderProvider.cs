using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Femi.MW.REST.Models
{
    public class ContactViewModelBinderProvider : IModelBinderProvider
    {
        IModelBinder IModelBinderProvider.GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType == typeof(ContactParams))
                return new ContactViewModelBinder();

            return null;
        }
    }
}
