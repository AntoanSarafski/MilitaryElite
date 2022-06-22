using MilitaryyElite.Implementations;
using MilitaryyElite.Interfaces;
using System;
using System.Collections.Generic;

namespace MilitaryyElite
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<int, ISoldier> soldiers = new Dictionary<int, ISoldier>();

            while (input != "End")
            {
                string[] inputInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string soldierType = inputInfo[0];
                int id = int.Parse(inputInfo[1]);
                string firstName = inputInfo[2];
                string lastName = inputInfo[3];

                if (soldierType == "Private" )
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                    IPrivate @private = new Private(id, firstName,
                        lastName, salary);
                    soldiers.Add(id, @private);
                }
                else if (soldierType == "LeutenantGeneral")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                    ILieutenantGeneral leutenantGeneral = new LieutenantGeneral
                        (id, firstName, lastName, salary);
                }



                input = Console.ReadLine();
            }
        }
    }
}
