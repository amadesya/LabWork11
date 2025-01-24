string filePath = "logins.txt";
string login;

while (true)
{
    Console.Write("Введите логин: ");
    login = Console.ReadLine();

    var existingLogins = File.ReadAllLines(filePath)
                         .Select(line => line.Split(',')[0]);

    if (!existingLogins.Contains(login))
    {
        break;
    }

    Console.WriteLine("Логин уже существует. Пожалуйста, выберите другой.");
}

Console.Write("Введите пароль: ");

string password = Console.ReadLine();
string registrationDate = DateTime.Now.ToString("yyyy-MM-dd");

using (StreamWriter writer = new StreamWriter(filePath, true))
{
    writer.WriteLine($"{login},{password},{registrationDate}");
}

Console.WriteLine("Вы успешно зарегистрированы!");