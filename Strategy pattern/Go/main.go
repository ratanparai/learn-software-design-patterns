package main

import "fmt"

func main() {
	calculator := Addition{}
	calc := NewMyCalculator(calculator)
	result := calc.Calculate(3, 3)
	fmt.Printf("The result is %d \n", result)
}
