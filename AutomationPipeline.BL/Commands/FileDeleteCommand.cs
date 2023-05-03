using AutomationPipeline.Model.Common.Commands;

namespace AutomationPipeline.BL.Commands
{
    public class FileDeleteCommand : IFileDeleteCommand
    {
        public string FilePath { get  ; set ; }

        public void Execute(Action<string> printAction)
        {
            printAction("Start FileDeleteCommand");
            File.Delete(FilePath);
            printAction("End FileDeleteCommand");
        }
    }
}
