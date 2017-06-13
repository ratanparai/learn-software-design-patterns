#include<iostream>
#include "Calculator.h"
#include "Addition.h"
#include "Substraction.h"

int main(int argc, char *argv[])
{
	char c;

	Addition add;
	Substraction sub;
	
	Calculator calc;
	calc.setStrategy(&add);

	int result = calc.calculate(2, 5);
	calc.setStrategy(&sub);
	int result2 = calc.calculate(5, 3);

	std::cout << "Hello World! The result is : ";
	std::cout << result << " And " << result2;
	std::cin >> c;

	return 0;
}