namespace Bank_in_c_;

public class Worker : Bank, IOrganize
{
    public Worker()
    {
        salary = Salary;
        position = Position;
        starttime=Start_Time;
        endtime=End_Time;
    }
    private int salary;

	public int Salary
	{
		get { return salary; }
		set { salary = value; }
	}
	private string position;

	public string Position
    {
		get { return position; }
		set { position = value; }
	}
    private int endtime;

    public int End_Time
    {
        get { return endtime; }
        set { endtime = value; }
    }
    private string starttime;

    public string Start_Time
    {
        get { return starttime; }
        set { starttime = value; }
    }

    public void organize()
    {
        Console.WriteLine("sdwef");
    }
}

