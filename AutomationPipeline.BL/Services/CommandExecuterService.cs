using AutomationPipeline.Model.Common.Commands;
using AutomationPipeline.Model.Exceptions;
using AutomationPipeline.Model.Services;

namespace AutomationPipeline.BL.Services
{
    public class CommandExecuterService : ICommandExecuterService
    {
        public async Task ExecuteAsync(ICommandFile commandFile,Action<string> printAction)
        {
            try
            {
                printAction("Start CommandExecuterService");
                printAction("****************************");
                foreach (var command in commandFile.Commands)
                {
                    command.Execute(printAction);
                    printAction("\n\n");
                }
                printAction("****************************");
                printAction("End CommandExecuterService");
            }
            catch (Exception e)
            {
                throw new CommandExecuteException("CommandExecuterService failed to execute command", e);
            }
           
        }
    }
}
