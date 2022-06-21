using System.Collections.Generic;

namespace MilitaryyElite.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        public List<IMission> Missions { get; set; }

        public void CompleteMission(string codeName);
    }
}
