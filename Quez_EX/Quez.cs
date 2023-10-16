namespace Quez_EX;

public class Quez
{
    public List<Question> questions = new();
    public List<string[]> answers = new();
    public void AddQuestion()
    {
        foreach (var question in questions)
        {
            answers.Add(question.GetQuestion());
            Console.WriteLine(answers);
        }
    }
}