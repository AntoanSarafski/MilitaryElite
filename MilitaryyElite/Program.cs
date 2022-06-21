using System;

namespace MilitaryyElite
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string soldierType = inputInfo[0];
                int id = int.Parse(inputInfo[1]);
                string firstName = inputInfo[2];
                string lastName = inputInfo[3];
            }
        }
    }
}
