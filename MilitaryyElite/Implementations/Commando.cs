using MilitaryyElite.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryyElite.Implementations
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName,
            decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public List<IMission> Missions { get ; set ; }

        public void CompleteMission(string codeName)
        {
            var mission = this.Missions
                .FirstOrDefault(x => x.CodeName == codeName);
            // check if mission exists
            mission.State = State.Finished;
        }
    }
}
