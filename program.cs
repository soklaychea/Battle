Public class Program 
{
	private string _first;
	private string _last;

	public Program(string fname, string lname)
	{
		_first = fname;
		_last = lname
	}

	public void Print()
	{
		Console.WriteLine("Hello this is " + _first + _last);
	}
}
