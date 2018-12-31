package main

type Subtraction struct{}

func (Subtraction) Calculate(numberOne, numberTwo int64) int64 {
	return numberOne - numberTwo
}
