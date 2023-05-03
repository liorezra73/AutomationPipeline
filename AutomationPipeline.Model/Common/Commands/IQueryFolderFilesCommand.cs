namespace AutomationPipeline.Model.Common.Commands
{
    public interface IQueryFolderFilesCommand : ICommand
    {
        string FolderPath { get; set; }
    }
}
