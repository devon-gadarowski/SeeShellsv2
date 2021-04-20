﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeShellsV2.Data
{
    public class ProgramInstallEvent : ShellEvent, IShellEvent
    {
        public override string LongDescriptionPattern => "A shellbag that documents a file-system entry was found. The shellbag's fields describe a file-entry that was created in one of {USER}'s program-related directories at {TIMESTAMP}, suggesting that they may have installed a program associated with {PLACE} at that time.";
    }
}
