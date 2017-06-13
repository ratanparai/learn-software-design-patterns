#include "Calculator.h"
#include "CalculateStrategy.h"


void Calculator::setStrategy(CalculateStrategy *calc)
{
	strategy = calc;
}

int Calculator::calculate(int a, int b) {
	return strategy->Calculate(a, b);
}



