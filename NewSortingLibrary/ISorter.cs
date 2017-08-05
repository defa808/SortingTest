﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary
{
    public interface ISorter<T>
    {
        IEnumerable Sort(IEnumerable array);
    }
}
