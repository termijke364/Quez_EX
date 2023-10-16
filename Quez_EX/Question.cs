using System.Xml.Serialization;

namespace Quez_EX;

public class Question
{
    private string path = "question.xml";

    public Question()
    {
    }

    public string[] GetQuestion()
    {
        XmlSerializer serializer = new(typeof(string[]));
        using FileStream fsStream = new(path, FileMode.Open);

        var questionArray = (string[])serializer?.Deserialize(fsStream);

        return questionArray.ToArray();
    }
}

/* public void writetofile()
    {
        string[] str = new[]
        { "sdasd33;" ,
            "sadasd;" ,
            "234234;" ,
            "dfgdfg;" ,
            "dsfsdf;",
    };

        XmlSerializer serializer = new(typeof(string[]));

        using (FileStream fStream = new(path, FileMode.Create))
        {
            serializer.Serialize(fStream, str);
        }
    }*/