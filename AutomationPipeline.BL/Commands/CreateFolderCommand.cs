using AutomationPipeline.Model.Common.Commands;

namespace AutomationPipeline.BL.Commands
{
    public class CreateFolderCommand : ICreateFolderCommand
    {
        public string FolderPath { get ; set ; }
        public string FolderName { get ; set ; }

        public void Execute(Action<string> printAction)
        {
            printAction("Start CreateFolderCommand");
            Directory.CreateDirectory(Path.Combine(FolderPath, FolderName));
            printAction("End CreateFolderCommand");
        }
    }
}
