using System.Collections.Generic;

namespace MilitaryyElite.Interfaces
{
    public interface ILieutenantGeneral 
    {
        public List<IPrivate> Privates { get; set; }
    }
}
