Console.WriteLine("Введите имя файла");
var fileName = Console.ReadLine();

FileInfo fileInfo = new FileInfo(fileName);
if (fileInfo.Exists)
{
    Console.WriteLine($"Файл с именем {fileName} существует");
    using (StreamReader reader = new StreamReader(fileInfo.FullName))
    {
        string text = await reader.ReadToEndAsync();
        Console.WriteLine(text);
    }
}
else
{
    Console.WriteLine($"Файл с именем {fileName} не существует");
}
