using AutomationPipeline.Model.Common.Commands;

namespace AutomationPipeline.BL.Commands
{
    public class ConditionalCountRowsFileCommand : IConditionalCountRowsFileCommand
    {
        public string SourceFile { get ; set ; }
        public string SearchString { get ; set ; }

        public void Execute(Action<string> printAction)
        {
            printAction("Start ConditionalCountRowsFileCommand");
            var count = File.ReadLines(SourceFile).Count(line => line.Contains(SearchString));
            printAction($"Count of rows in the file that contain the search string:{count}");
            printAction("End ConditionalCountRowsFileCommand");
        }
    }
}
