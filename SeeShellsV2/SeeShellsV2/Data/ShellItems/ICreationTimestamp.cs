﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeShellsV2.Data
{
    public interface ICreationTimestamp : IShellItem
    {
        DateTime CreationDate { get; }
    }
}
