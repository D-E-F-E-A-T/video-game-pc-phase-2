#include "pch.h"

class ScreenUtils
{
public:
	static void CalculateSquareCenter(
		float screenWidth, 
		float screenHeight, 
		int column, 
		int row, 
		float * x, 
		float * y);

	static void ConvertGlobalToGridLocation(
		float2 globalPt,
		float * x,
		float * y);
};