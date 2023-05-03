using AutomationPipeline.Model.Common.Commands;
using System.Net;

namespace AutomationPipeline.BL.Commands
{
    public class DownloadFileCommand : IDownloadFileCommand
    {
        public string SourceUrl { get ; set ; }
        public string OutputFile { get; set ; }

        public void Execute(Action<string> printAction)
        {
            printAction("Start DownloadFileCommand");
            using (var client = new WebClient())
            {
                client.DownloadFile(SourceUrl, OutputFile);
            }
            printAction("End DownloadFileCommand");
        }
    }
}
