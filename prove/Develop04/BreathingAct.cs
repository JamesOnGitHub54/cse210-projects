public class BreathingAct
{
    private string _name;
    private string _description;
    private int _duration;

    public BreathingAct(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetBreathingDesc()
    {
        return "Welcome to the Breathing Activity.\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing./n";
    }
    public int GetDuration()
    {
    return 0;
    }
}