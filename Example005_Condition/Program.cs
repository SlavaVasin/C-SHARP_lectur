Console.Write("Введите имя пользователья: ");
string username = Console.ReadLine()!;

if(username.ToLower() == "ева")
{
    Console.WriteLine("Ура, это же Ева!!!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}