using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemoConsoleApp.Client
{
    public class CanonMG2470 : IPrintScanContent
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("Photo Copy Done");
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done");
            return true;
        }
    }
}
