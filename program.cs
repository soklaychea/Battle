public class Student 
{
	private string _first;
	private string _last;
	private int _age;
	private string _edu;

	public Student() : this ("Tim", "Tom", 21, "Swinburne")
	{
	}

	public Student(string fname, string lname, int age, string edu)
	{
		_first = fname;
		_last = lname;
		_age = age;
		_edu = edu;
	}

	public void Print()
	{

		Console.WriteLine("Hello this is {0} {1}", _first, _last);
		Console.WriteLine("I am {0} years old", _age);
		Console.WriteLine("currently studying {0}", _edu);	
	}
}