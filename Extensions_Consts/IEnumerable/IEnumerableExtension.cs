using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Extensions.IEnumerable
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> collection)
        {
            var random = new Random(); 
            return collection.OrderBy(x=>random.Next()) ;
        }
    }
}
