using AutomationPipeline.Model.Common.Commands;

namespace AutomationPipeline.BL.Commands
{
    public class CommandFile : ICommandFile
    {
        public ICollection<ICommand> Commands { get; set; }
    }
}
