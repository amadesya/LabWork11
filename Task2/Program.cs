Console.WriteLine("Введите имя файла");
var fileName = Console.ReadLine();

FileInfo fileInfo = new FileInfo(fileName);
if (fileInfo.Exists)
{
    Console.WriteLine($"Файл с именем {fileName} существует и открыт на дозапись");
}
else
{
    Console.WriteLine($"Файл с именем {fileName} не существует, файл будет создан");
}

using (StreamWriter writer = new StreamWriter(fileName, true))
{
    while(true)
    {
        string lines = Console.ReadLine();
        if (lines == "end")
            break;
        writer.WriteLine(lines);
    }
}