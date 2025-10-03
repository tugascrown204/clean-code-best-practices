package main

import "fmt"

type Report struct {
    Title   string
    Content string
}

func (r Report) Generate() string {
    return fmt.Sprintf("Report: %s\n%s", r.Title, r.Content)
}

func main() {
    report := Report{Title: "Monthly Sales", Content: "Sales increased by 20%"}
    fmt.Println(report.Generate())
}
