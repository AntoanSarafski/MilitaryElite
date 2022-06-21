using MilitaryyElite.Interfaces;
using System.Collections.Generic;

namespace MilitaryyElite.Implementations
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName,
            decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary, corps)
        {
        }

        public List<IMission> Missions { get ; set ; }

        public void CompleteMission(string codeName)
        {
            
        }
    }
}
