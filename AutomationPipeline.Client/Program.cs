using AutomationPipeline.BL.Converters;
using AutomationPipeline.BL.Services;
using AutomationPipeline.Model.Common.Commands;
using AutomationPipeline.Model.Converters;
using AutomationPipeline.Model.Services;
using System.Reflection;

namespace AutomationPipeline.Client
{
    internal class Program
    {
        private static IXmlConverter _xmlCommandFileConverter;
        private static ICommandExecuterService _commandExecuterService;
        private static IFileService _fileService;

        static void Main(string[] args)
        {
            Run();
            Console.ReadLine();
        }

        static void StartUp()
        {
            InitialXmlCommandFileConverter();
            _commandExecuterService = new CommandExecuterService();
            _fileService = new FileService();
        }

        private static void InitialXmlCommandFileConverter()
        {
            var commandTypes = new List<Type>();
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                var types = assembly.GetTypes()
                    .Where(t => typeof(ICommand).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);
                commandTypes.AddRange(types);
            }

            try
            {
                var projectFolderPath = AppDomain.CurrentDomain.BaseDirectory;
                var dllPath = Path.Combine(projectFolderPath, "Extensions", "Extension.dll");
                var extensionAssembly = Assembly.LoadFrom(dllPath);
                var extensionTypes = extensionAssembly.GetTypes()
                       .Where(t => typeof(ICommand).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);
                commandTypes.AddRange(extensionTypes);
            }
            catch (Exception)
            {
                Console.WriteLine("No Extension dll found...");
            }
         


            _xmlCommandFileConverter = new XmlCommandFileConverter(commandTypes);
        }

        static async void Run()
        {
            StartUp();

            await Console.Out.WriteLineAsync("Welcome to Automation Pipeline system \n\n\n");
            await Console.Out.WriteAsync("Enter XML file path:\n\n\n");
            var inputFilePath = await Console.In.ReadLineAsync();
            var xmlContent = _fileService.GetFile(inputFilePath);
            var commandFile = _xmlCommandFileConverter.Deserializer<ICommandFile>(xmlContent);
            await _commandExecuterService.ExecuteAsync(commandFile, Console.WriteLine);
        }
    }
}