using AutomationPipeline.Model.Common.Commands;

namespace AutomationPipeline.BL.Commands
{
    public class WaitCommand : IWaitCommand
    {
        public int WaitTimeInSeconds { get ; set ; }

        public void Execute(Action<string> printAction)
        {
            printAction("Start WaitCommand");
            Thread.Sleep(WaitTimeInSeconds * 1000);
            printAction("End WaitCommand");
        }
    }
}
