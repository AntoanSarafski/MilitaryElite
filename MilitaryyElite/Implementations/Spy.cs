using MilitaryyElite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace MilitaryyElite.Implementations
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber) 
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get ; set ; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id}");
            sb.AppendLine($"Code Number: {CodeNumber}");

            return sb.ToString().TrimEnd();
        }
    }
}
