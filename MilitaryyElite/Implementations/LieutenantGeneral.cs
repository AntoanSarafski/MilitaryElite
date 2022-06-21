using MilitaryyElite.Interfaces;
using System.Collections.Generic;

namespace MilitaryyElite.Implementations
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName,
            decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<IPrivate>();
        }

        public List<IPrivate> Privates { get; set; }
    }
}
