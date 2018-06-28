using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqWriter {
    public static class Extensions {
        public static IEnumerable<T> Write<T>(this IEnumerable<T> source, string title = "") {
            Console.WriteLine("{1} {{{0}}}", string.Join(", ", source), title);
            return source;
        }
        public static T[] Write<T>(this T[] source, string title = "") {
            Console.WriteLine("{1} [{0}]", string.Join(", ", source), title);
            return source;
        }
        public static void Write<T>(this List<T> source, string title = "") {
            Console.WriteLine("{1} [{0}]", string.Join(", ", source), title);
        }
    }
}