
namespace AutomationPipeline.Model.Exceptions
{
    public class CommandExecuteException : Exception
    {
        public CommandExecuteException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
