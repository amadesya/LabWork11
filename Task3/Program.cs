Console.WriteLine("Введите имя файла: ");
var fileName = Console.ReadLine();


FileInfo fileInfo = new FileInfo(fileName);
if (fileInfo.Exists)
{
    Console.WriteLine($"Файл с именем {fileName} существует");
    Console.WriteLine("Введите искомый текст: ");
    var fileText = Console.ReadLine();
    var line = File.ReadAllLines(fileInfo.FullName);
    for(int i = 0; i < line.Length;i++ )
    {
        if (line[i].Contains(fileText))
        {
            Console.WriteLine($"Найдено в строке {i+1}: {line[i].ToString()}");
        }
    }
}
else
{
    Console.WriteLine($"Файл с именем {fileName} не существует");
}
