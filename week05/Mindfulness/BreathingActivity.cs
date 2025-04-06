public class BreathingActivity : Activity
{
    private List<string> _prompts;

    public BreathingActivity(string Name, string Description, int Duration) 
    : base(Name, Description, Duration)
    {
        _prompts = new List<string> { "Breathe in...", "Breathe out..." };
    }

    public void Run()
    {
        DisplayStartingMessage();
        int elapsed = 0;

        while (elapsed < Duration)
        {
            foreach (var prompt in _prompts)
            {
                if (elapsed >= Duration) break;
                Console.WriteLine(prompt);
                ShowCountDown(3);
                elapsed += 3;
            }
        }

        DisplayEndingMessage();
    }
}
