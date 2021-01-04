using System;
using System.Collections.Generic;
using System.Text;

namespace OpdrachtBoeken
{
    interface IVoorwerpen
    {
        void Print();
        abstract decimal Winst { get; }
    }
}
