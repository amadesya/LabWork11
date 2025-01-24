using System.Security.Cryptography;

Console.WriteLine("Введите имя файла");
var fileName = Console.ReadLine();

FileInfo fileInfo = new FileInfo(fileName);
if (fileInfo.Exists)
{
    Console.WriteLine($"Файл с именем {fileName} существует");

}
else
{
    Console.WriteLine($"Файл с именем {fileName} не существует, файл будет создан");
    fileInfo.Create();
}
