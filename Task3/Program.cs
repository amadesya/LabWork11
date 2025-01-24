Console.WriteLine("Введите имя файла: ");
var fileName = Console.ReadLine();
Console.WriteLine("Введите искомый текст: ");
var fileText = Console.ReadLine();

FileInfo fileInfo = new FileInfo(fileName);
if (fileInfo.Exists)
{
    Console.WriteLine($"Файл с именем {fileName} существует");
    foreach (var line in File.ReadLines(fileName))
    {
        if (line.Contains(fileText))
        {
            Console.WriteLine($"Найдено в строке:{line}");
        }
    }
}
else
{
    Console.WriteLine($"Файл с именем {fileName} не существует");
}
