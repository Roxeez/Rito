using System.Collections.Generic;
using NFluent;

namespace Rito.Tests.Extensions
{
    public static class CheckExtension
    {
        public static void IsNotEmpty<T>(this ICheck<IEnumerable<T>> check)
        { 
            check.Not.IsEmpty();
        }
    }
}