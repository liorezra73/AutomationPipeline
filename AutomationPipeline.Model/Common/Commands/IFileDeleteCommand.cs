namespace AutomationPipeline.Model.Common.Commands
{
    public interface IFileDeleteCommand : ICommand
    {
        string FilePath { get; set; }
    }
}
