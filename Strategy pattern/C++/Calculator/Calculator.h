#pragma once
#include "CalculateStrategy.h"

class Calculator
{
public:
	void setStrategy(CalculateStrategy *strategy);
	
	int calculate(int a, int b);

private:
	CalculateStrategy *strategy;
};

