namespace AutomationPipeline.Model.Common.Commands
{
    public interface ICreateFolderCommand : ICommand
    {
        string FolderPath { get; set; }
        string FolderName { get; set; }
    }
}
