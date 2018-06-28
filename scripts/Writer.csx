#! "netcoreapp2.1"
#r "../src/LinqWriter/bin/Debug/netcoreapp2.1/LinqWriter.dll"

using LinqWriter;


var a = new List<int> { 1, 2, 3, 4, 5 };
a.Write("List");

var b = new List<int> { 1, 2, 3, 4, 5 }.Select(x => x);
b.Write("IEnumerable");

var c = new int[] { 1, 2, 3, 4, 5 };
c.Write("Array");