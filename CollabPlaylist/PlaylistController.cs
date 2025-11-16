using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollabPlaylist
{
    public class PlaylistController
    {
        private List<ICommand> commandQueue = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            commandQueue.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in commandQueue)
                command.Execute();

            // Clear the queue after execution
            commandQueue.Clear();
        }
    }
}
