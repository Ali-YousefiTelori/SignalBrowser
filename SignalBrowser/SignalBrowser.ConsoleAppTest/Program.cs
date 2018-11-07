using SignalBrowser.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalBrowser.ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Compiler compiler = new Compiler();
            var block = compiler.Compile(@"var address = ""http://localhost:4628"";
		var name = ""reza"";
		console.log(address,name);");
            Console.ReadLine();
        }
    }
}
