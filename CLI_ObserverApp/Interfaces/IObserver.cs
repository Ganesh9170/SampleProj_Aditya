﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI_ObserverApp.Interfaces
{
    public interface IObserver
    {
        void Update(string message);
    }
}
