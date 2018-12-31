package main

import "fmt"

type Calculator interface {
	Calculate(numberOne, numberTwo int64) int64
}

type MyCalculator struct {
	calc Calculator
}

func NewMyCalculator(calculator Calculator) MyCalculator {
	return MyCalculator{calc: calculator}
}

func (calc MyCalculator) Calculate(numberOne, numberTwo int64) int64 {
	result := calc.calc.Calculate(numberOne, numberTwo)
	return result
}

type ICar interface {
	Drive()
	Horn()
}

type Honda struct{}

func (Honda) Drive() {
	fmt.Println("I am driving the car")
}

func (Honda) Horn() {
	fmt.Println("The horn is so loud")
}
