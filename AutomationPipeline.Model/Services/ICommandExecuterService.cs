using AutomationPipeline.Model.Common.Commands;

namespace AutomationPipeline.Model.Services
{
    public interface ICommandExecuterService
    {
        Task ExecuteAsync(ICommandFile commandFile, Action<string> printAction);
    }
}
