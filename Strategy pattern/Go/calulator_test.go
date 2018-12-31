package main

import "testing"


func TestAddStrategy(t *testing.T) {
	additionStrategy := Addition{}
	calculator := NewMyCalculator(additionStrategy)

	tables := []struct{
		numberOne int64
		numberTwo int64
		expected int64

	}{
		{1,2,3},
		{3,4,7},
		{5,6,11},
		{-3,-6, -9},
		{-5, 6, 1},
		{0, 4, 4},
		{5, -5, 0},
	}


	for _, table := range tables {
		if actual := calculator.Calculate(table.numberOne, table.numberTwo); actual != table.expected{
			t.Errorf("Sum of %d and %d should be %d, but got %d", table.numberOne, table.numberTwo, table.expected, actual)
		}
	}
}

func TestSubtractionStrategy(t *testing.T)  {
	tables := []struct{
		numberOne int64
		numberTwo int64
		expected int64

	}{
		{1,2,-1},
		{3,4,-1},
		{5,6,-1},
		{-3,-6, 3},
		{-5, 6, -11},
		{0, 4, -4},
		{5, -5, 10},
	}

	subtractionStrategy := &Subtraction{}
	calculator := NewMyCalculator(subtractionStrategy)

	for _, table := range tables {
		if actual := calculator.Calculate(table.numberOne, table.numberTwo); actual != table.expected{
			t.Errorf("Sum of %d and %d should be %d, but got %d", table.numberOne, table.numberTwo, table.expected, actual)
		}
	}
}
