public class Program {
	private string _helloWorld = "Hello World!"; 

	public string GetHelloWorld() {
		return _helloWorld;
	}

	public static void Main() {
		Program p = new Program();

		Console.WriteLine(p.GetHelloWorld());
	}
}
