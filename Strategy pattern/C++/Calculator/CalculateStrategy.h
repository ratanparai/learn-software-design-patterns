#pragma once
class CalculateStrategy
{
public:

	// virtual	~CalculateStrategy();
	virtual int Calculate(int numberOne, int numberTwo) const = 0;
};

