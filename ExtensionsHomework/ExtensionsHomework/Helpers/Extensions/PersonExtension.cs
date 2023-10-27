using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsHomework.Helpers.Extensions;
public static class PersonExtensions
{
    public static string GetFullName(this Person person)
    {
        return $"{person.Name} {person.Surname}";
    }
}

