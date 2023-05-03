# AutomationPipeline


### Adding extentions:
1. create class library with "Extentions" as it name.
2. set reference to AutomationPipeline.Model.
3.implement ICommand.
4.create/use folder Extentions in th client layer.
5.build your dll and copy it to Extentions folder.

### Xml example:
<?xml version="1.0"?>
<CommandFile xmlns:i="http://www.w3.org/2001/XMLSchema-instance"
             xmlns="http://schemas.datacontract.org/2004/07/AutomationPipeline.BL.Commands">
	<Commands xmlns:a="http://schemas.microsoft.com/2003/10/Serialization/Arrays">
		<a:anyType i:type="FileCopyCommand">
			<DestinationFile>destination.txt</DestinationFile>
			<SourceFile>source.txt</SourceFile>
		</a:anyType>
		<a:anyType i:type="FileDeleteCommand">
			<FilePath>file.txt</FilePath>
		</a:anyType>
		<a:anyType i:type="QueryFolderFilesCommand">
			<FolderPath>C:\MyFolder</FolderPath>
		</a:anyType>
		<a:anyType i:type="CreateFolderCommand">
			<FolderName>MyFolder</FolderName>
			<FolderPath>C:\</FolderPath>
		</a:anyType>
		<a:anyType i:type="DownloadFileCommand">
			<OutputFile>file.txt</OutputFile>
			<SourceUrl>https://www.example.com/file.txt</SourceUrl>
		</a:anyType>
		<a:anyType i:type="WaitCommand">
			<WaitTimeInSeconds>5</WaitTimeInSeconds>
		</a:anyType>
		<a:anyType i:type="ConditionalCountRowsFileCommand">
			<SearchString>example</SearchString>
			<SourceFile>file.txt</SourceFile>
		</a:anyType>
	</Commands>
</CommandFile>
