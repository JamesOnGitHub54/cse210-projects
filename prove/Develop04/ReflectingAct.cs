public class ReflectingAct
{
    private string _name;
    private string _description;
    private int _duration;
    private int _promptNumber;

    public ReflectingAct(string name, string description, int duration, int promptNumber)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _promptNumber = promptNumber;
    }

    public string GetReflectingDesc()
    {
        return "Welcome to the Reflecting Activity.\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life./n";
    }

    public int GetDuration()
    {
    return 0;
    }
}