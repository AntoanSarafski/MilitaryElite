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

                    for (int i = 5; i < inputInfo.Length; i++)
                    {
                        int inputID = int.Parse(inputInfo[i]);
                        IPrivate @private = soldiers[inputID] as IPrivate;
                        leutenantGeneral.Privates.Add(@private);
                    }
                    soldiers.Add(id, leutenantGeneral);
                }
                else if (soldierType == "Engineer")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                    string corpAsString = inputInfo[5];

                    bool isValidEnum = Enum.TryParse
                        (corpAsString, out Corps result);

                    if (!isValidEnum)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    IEngineer engineer = new Engineer(id, firstName,
                        lastName, salary, result);

                    for (int i = 6; i < inputInfo.Length; i+=2)
                    {
                        string partName = inputInfo[i];
                        int workedHours = int.Parse(inputInfo[i + 1]);

                        IRepair repair = new Repair(partName, workedHours);

                        engineer.Repairs.Add(repair);
                    }
                    soldiers.Add(id, engineer);

                }
                else if (soldierType == "Comando")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                    string corpAsString = inputInfo[5];

                    bool isValidEnum = Enum.TryParse
                        (corpAsString, out Corps result);

                    if (!isValidEnum)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    ICommando commando = new Commando(id, firstName,
                        lastName, salary, result);

                    for (int i = 6; i < inputInfo.Length; i += 2)
                    {
                        string missionCode = inputInfo[i];
                        string missionStateAsString 
                            = inputInfo[i + 1];

                        bool isValidMission = Enum.TryParse
                            (missionStateAsString, out State state);

                        if (!isValidMission)
                        {
                            continue;
                        }

                        IMission mission = new Mission(missionCode, state);

                        commando.Missions.Add(mission);
                    }
                    soldiers.Add(id, commando);
                }

                else if (soldierType == "Spy")
                {
                    int codeNumber = int.Parse(inputInfo[4]);

                    ISpy spy = new Spy(id, firstName, lastName, codeNumber);

                    soldiers.Add(id, spy);
                }



                input = Console.ReadLine();
            }
        }
    }
}
