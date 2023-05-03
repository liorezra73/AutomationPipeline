namespace AutomationPipeline.Model.Common.Commands
{
    public interface IWaitCommand : ICommand
    {
        int WaitTimeInSeconds { get; set; }
    }
}
