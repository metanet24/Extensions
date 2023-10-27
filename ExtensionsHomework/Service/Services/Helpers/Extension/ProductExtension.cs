using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Helpers.Extension
{
    public static  class ProductExtension
    {
        public static string GetFullName(this  person)
        {
            return $"{person.Name} {person.Surname}";
        }
    }
}
