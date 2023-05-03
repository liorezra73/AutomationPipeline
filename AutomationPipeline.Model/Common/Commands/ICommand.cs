namespace AutomationPipeline.Model.Common.Commands
{
    public interface ICommand
    {
        void Execute(Action<string> printAction);
    }
}
