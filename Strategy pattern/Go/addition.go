package main

type Addition struct {
}

func (Addition) Calculate(numberOne, numberTwo int64) int64 {
	return numberOne + numberTwo
}
