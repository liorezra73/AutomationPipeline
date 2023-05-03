namespace AutomationPipeline.Model.Common.Commands
{
    public interface IDownloadFileCommand : ICommand
    {
        string SourceUrl { get; set; }
        string OutputFile { get; set; }
    }
}
