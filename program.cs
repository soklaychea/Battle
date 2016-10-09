public class Program 
{
	private string _first;
	private string _last;
	private int _age;
	private string _edu;

	public Program(string fname, string lname, int age, string edu)
	{
		_first = fname;
		_last = lname;
		_age = age;
		_edu = edu;
	}

	public void Print()
	{
		Console.WriteLine("Hello this is " + _first + _last);
		Console.WriteLine("I am " + _age + " years old");
		Console.WriteLine("currently studying " + _edu);
	}
}