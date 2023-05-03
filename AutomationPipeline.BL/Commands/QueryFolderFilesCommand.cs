using AutomationPipeline.Model.Common.Commands;

namespace AutomationPipeline.BL.Commands
{
    public class QueryFolderFilesCommand : IQueryFolderFilesCommand
    {
        public string FolderPath { get ; set ; }

        public void Execute(Action<string> printAction)
        {
            printAction("Start QueryFolderFilesCommand");
            var files = Directory.GetFiles(FolderPath);
            printAction("files list:");
            Array.ForEach(files, file => printAction(file));
            printAction("End QueryFolderFilesCommand");
        }
    }
}
