using MilitaryyElite.Interfaces;
using System.Collections.Generic;

namespace MilitaryyElite.Implementations
{
    public class Engeneer : SpecialisedSoldier, IEngeneer
    {
        public Engeneer(int id, string firstName, string lastName,
            decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = new List<IRepair>();
        }

        public List<IRepair> Repairs { get ; set ; }
    }
}
