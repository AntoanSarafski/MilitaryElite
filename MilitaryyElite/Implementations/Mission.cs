using MilitaryyElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryyElite.Implementations
{
    public class Mission : IMission
    {
        public Mission(string codeName, State state)
        {
            CodeName = codeName;
            State = state;
        }

        public string CodeName { get; set; }

        public State State { get; set; }
    }
}
