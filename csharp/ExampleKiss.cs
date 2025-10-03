public class Program {
    public static bool IsEven(int number) {
        return number % 2 == 0;
    }

    public static void Main() {
        Console.WriteLine(IsEven(4));  // true
        Console.WriteLine(IsEven(5));  // false
    }
}
