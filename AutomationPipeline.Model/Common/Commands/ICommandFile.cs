namespace AutomationPipeline.Model.Common.Commands
{
    public interface ICommandFile
    {
        ICollection<ICommand> Commands { get; set; }
    }
}
