﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemoConsoleApp
{
    public interface IPrintTask
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool FaxContent(string content);
        bool PhotoCopyContent(string content);
    }
}
