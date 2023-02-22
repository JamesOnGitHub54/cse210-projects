public class ListeningAct
{
    private string _name;
    private string _description;
    private string _items;

    public ListeningAct(string name, string description, string items)
    {
        _name = name;
        _description = description;
        _items = items;
    }

    public string GetListeningDesc()
    {
        return "Welcome to the Listening Activity.\nThis activity will help you reflect on the good in your life by having you list as many things as you can in a certain area./n";
    }
}