class Report {
    constructor(title, content) {
        this.title = title;
        this.content = content;
    }

    generate() {
        return `Report: ${this.title}\n${this.content}`;
    }
}

const report = new Report('Monthly Sales', 'Sales increased by 20%');
console.log(report.generate());
