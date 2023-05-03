using AutomationPipeline.Model.Common.Commands;

namespace AutomationPipeline.BL.Commands
{
    public class FileCopyCommand : IFileCopyCommand
    {
        public string SourceFile { get; set; }
        public string DestinationFile { get; set; }

        public void Execute(Action<string> printAction)
        {
            printAction("Start FileCopyCommand");
            File.Copy(SourceFile, DestinationFile, true);
            printAction("End FileCopyCommand");
        }
    }
}
