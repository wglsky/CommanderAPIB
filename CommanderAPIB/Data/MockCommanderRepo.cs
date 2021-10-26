using CommanderAPIB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderAPIB.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> {
                new Command { Id = 0, HowTo="Boil an egg", Line="Boil water", Platform ="Pan or Kettle"},
                new Command { Id = 1, HowTo="Cook rice", Line="Add water and rice", Platform ="Rice cooker"},
                new Command { Id = 2, HowTo="Make a coffee", Line="Start coffee machine", Platform ="Coffee machine"},
            };
            return commands;
        }

        public Command GetCommandById(int id)
        { 
            return new Command { Id = 0, HowTo="Boil an egg", Line="Boil water", Platform ="Pan or Kettle"};
        }
    }
}
