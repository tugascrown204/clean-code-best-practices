public class Report {
    private string title;
    private string content;

    public Report(string title, string content) {
        this.title = title;
        this.content = content;
    }

    public string Generate() {
        return "Report: " + title + "\n" + content;
    }
}

public class Program {
    public static void Main() {
        Report report = new Report("Monthly Sales", "Sales increased by 20%");
        Console.WriteLine(report.Generate());
    }
}
