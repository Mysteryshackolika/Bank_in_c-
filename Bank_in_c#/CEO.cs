namespace Bank_in_c_;

public class CEO : Bank, IOrganize
{
    public CEO()
    {
		salary = Salary;
		position = Position;
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


	public void organize()
    {
        Console.WriteLine("a");
    }
	public void control()
	{
		Console.WriteLine("Control");
	}
    public void makemeeting()
    {
        Console.WriteLine("Makemeeting");
    }
    public void decrase_percantge(int percent)
    {
        Console.WriteLine($"decrase_percantge: {percent}");
    }
}
