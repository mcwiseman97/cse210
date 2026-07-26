class ReflectionActivity : Activity
{
    public List<Activity> _prompts;
    public List<Activity> _questions;

    public ReflectionActivity()
    {
        _prompts  = new List<Activity>();
        _questions  = new List<Activity>();
    }

    public void Run()
    {
        
    }

    public string GetRandomQuestion()
    {
        var randomQuestion = _questions;
        int randomIndex = Random.Shared.Next(randomQuestion.Count);
        string question = randomQuestion[randomIndex];
        return question;
    }
}