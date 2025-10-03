class Report:
    def __init__(self, title, content):
        self.title = title
        self.content = content

    def generate(self):
        return f'Report: {self.title}\n{self.content}'

report = Report('Monthly Sales', 'Sales increased by 20%')
print(report.generate())
