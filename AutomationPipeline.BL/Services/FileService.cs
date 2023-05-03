using AutomationPipeline.Model.Services;

namespace AutomationPipeline.BL.Services
{
    public class FileService : IFileService
    {
        public string GetFile(string path)
        {
            var streamReader = new StreamReader(path);
            using (streamReader)
            {
                var fileContent = streamReader.ReadToEnd();
                return fileContent;
            }

        }
    }
}
