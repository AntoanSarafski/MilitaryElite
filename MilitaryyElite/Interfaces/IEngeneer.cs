using System.Collections.Generic;
namespace MilitaryyElite.Interfaces
{
    public interface IEngeneer : ISpecialisedSoldier
    {
        public List<IRepair> Repairs { get; set; }
    }
}
