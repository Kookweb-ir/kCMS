using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace System
{
    public static class SystemExtensions
    {
        public static IEnumerable<string> FetchErrors(this ModelStateDictionary modelState)
        {
            return modelState.Values
                .SelectMany(x => x.Errors)
                .Select(x => x.ErrorMessage);
        }
    }
}