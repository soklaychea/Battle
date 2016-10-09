public class Program 
{
	private string _first;
	private string _last;

	public Program () : this ("Tim", "Tom")
	{
	}

	public Program(string fname, string lname)
	{
		_first = fname;
		_last = lname;
	}

	public void Print()
	{
		Console.WriteLine("Hello this is {0} {1}", _first, _last);
	}
}