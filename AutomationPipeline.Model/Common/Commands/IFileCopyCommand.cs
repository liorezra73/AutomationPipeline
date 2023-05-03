namespace AutomationPipeline.Model.Common.Commands
{
    public interface IFileCopyCommand : ICommand
    {
        string SourceFile { get; set; }
        string DestinationFile { get; set; }
    }
}
