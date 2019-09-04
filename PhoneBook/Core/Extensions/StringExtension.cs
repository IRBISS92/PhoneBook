using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBook.Core.Extensions
{
    public static class StringExtension
    {
        public static dynamic AsDynamic(this string json)
        {
            return JObject.Parse(json);
        }
    }
}