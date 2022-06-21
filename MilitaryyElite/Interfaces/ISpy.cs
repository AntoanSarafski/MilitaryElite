using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryyElite.Interfaces
{
    interface ISpy : ISoldier
    {
        public int CodeNumber { get; set; }
    }
}
