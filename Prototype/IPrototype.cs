﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory6
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
