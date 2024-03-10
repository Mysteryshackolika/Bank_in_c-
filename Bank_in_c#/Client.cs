namespace Bank_in_c_;

internal class Client:Bank
{
    public Client()
    {
        workadress = Workadress;
        salary = Salary;
        liveadress = Liveadress;
    }
    private int salary;

    public int Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    private string liveadress;

    public string Liveadress
    {
        get { return liveadress; }
        set { liveadress = value; }
    }
    private string workadress;

    public string Workadress
    {
        get { return workadress; }
        set { workadress = value; }
    }
}
