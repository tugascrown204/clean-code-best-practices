public class Report {
    private String title;
    private String content;

    public Report(String title, String content) {
        this.title = title;
        this.content = content;
    }

    public String generate() {
        return "Report: " + title + "\n" + content;
    }
}

public class Main {
    public static void main(String[] args) {
        Report report = new Report("Monthly Sales", "Sales increased by 20%");
        System.out.println(report.generate());
    }
}
