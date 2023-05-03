namespace AutomationPipeline.Model.Common.Commands
{
    public interface IConditionalCountRowsFileCommand : ICommand
    {
        string SourceFile { get; set; }
        string SearchString { get; set; }
    }
}
