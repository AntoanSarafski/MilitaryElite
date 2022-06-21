using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryyElite.Interfaces
{
    public interface IMission
    {
        public string CodeName { get; set; }

        public State State { get; set; }

    }
}
