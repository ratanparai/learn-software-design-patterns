#pragma once
#include "CalculateStrategy.h"
class Addition :
	public CalculateStrategy
{
public:
	virtual int Calculate(int numberOne, int numberTwo) const;
};

