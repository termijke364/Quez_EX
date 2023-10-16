using Quez_EX;
using System.Xml.Serialization;

public class Program
{
    public static int Main()
    {
        /*PlayerFactory facr = new PlayerFactory();
        facr.CreateUser();*/

       Quez quez = new Quez();
        quez.AddQuestion();

        

        return 0;
    }

    /*public static string[] readfile(string path)
    {
        XmlSerializer serializer = new(typeof(string[]));
        using FileStream fsStream = new(path, FileMode.Open);

        var questionArray = (string[])serializer?.Deserialize(fsStream);
        return questionArray.ToArray();
    }*/
}