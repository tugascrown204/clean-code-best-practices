package main

import "fmt"

func isEven(number int) bool {
    return number%2 == 0
}

func main() {
    fmt.Println(isEven(4))  // true
    fmt.Println(isEven(5))  // false
}
