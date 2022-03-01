﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Extensions
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<object> Randomize(this IEnumerable<object> collection)
        {
            var random = new Random(); 
            return collection.OrderBy(x=>random.Next()) ;
        }
    }
}