using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Users;

internal class PlayerFactory : UserFactory
{
    public string playerPath = "player.xml";

    public override User CreateUser()
    {
        Console.WriteLine("Введите логин: ");
        string login = Console.ReadLine();

        Console.WriteLine("Введите пароль: ");
        string password = Console.ReadLine();

        Player player = new Player(login, password);

        XmlSerializer serializer = new(typeof(Player));

        using (FileStream fStream = new(playerPath, FileMode.Append, FileAccess.Write))
        {
            serializer.Serialize(fStream, player);
        }

        return player;
    }

    /*private static void WriteToXml(string filePath, Player player)
    {
        using XmlTextWriter writer = new(filePath, Encoding.Default);
        writer.WriteStartDocument();

        writer.WriteStartElement("ArrayOfPlayer");
        writer.WriteStartElement("Player");
        writer.WriteElementString("login", player.login);
        writer.WriteElementString("password", player.password);

        writer.WriteEndElement();
        writer.WriteEndDocument();
    }*/
}