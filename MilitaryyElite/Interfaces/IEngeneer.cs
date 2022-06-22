using System.Collections.Generic;
namespace MilitaryyElite.Interfaces
{
    public interface IEngineer : ISpecialisedSoldier
    {
        public List<IRepair> Repairs { get; set; }
    }
}
