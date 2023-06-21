Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "artem")
{
    Console.WriteLine("Ура, это же АРТЕМ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
    }