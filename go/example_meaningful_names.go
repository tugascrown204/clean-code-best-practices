package main

import "fmt"

func calculateArea(width, height float64) float64 {
    return width * height
}

func main() {
    area := calculateArea(5, 10)
    fmt.Println(area)  // 50
}
