﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetShipping
{
    public class USPSError
    {
        public string Number { get; set; }
        public string Source { get; set; }
        public string Description { get; set; }
        public string HelpFile { get; set; }
        public string HelpContext { get; set; }
    }
}
