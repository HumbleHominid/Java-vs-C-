public class Main {
	private String _helloWorld = "Hello World!";

	public String getHelloWorld() {
		return _helloWorld;
	}

	public static void main(String agrs[]) {
		Main main = new Main();

		System.out.println(main.getHelloWorld);
	}
}
