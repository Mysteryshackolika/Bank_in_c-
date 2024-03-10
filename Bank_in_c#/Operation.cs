namespace Bank_in_c_;

public class Operation
{
    public void Date_Time()
    {
        DateTime time = DateTime.Now;
        Console.WriteLine($" Datetime: {time}");
    }
    private string proces_Name;

    public string Proces_Name
    {
        get { return proces_Name; }
        set { proces_Name = value; }
    }



}
