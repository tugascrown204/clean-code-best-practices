public class Rectangle {
    private double width;
    private double height;

    public Rectangle(double width, double height) {
        this.width = width;
        this.height = height;
    }

    public double CalculateArea() {
        return width * height;
    }
}

public class Program {
    public static void Main() {
        Rectangle rectangle = new Rectangle(5, 10);
        Console.WriteLine(rectangle.CalculateArea());  // 50
    }
}
