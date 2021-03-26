﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SeeShellsV2.Data;
using SeeShellsV2.Utilities;

namespace SeeShellsV2.Repositories
{
    public class PlaceCollection : ObservableSortedList<Place>, IDataRepository<Place>
    { }
}
