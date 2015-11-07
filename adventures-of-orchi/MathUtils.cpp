#include "pch.h"
#include <math.h>
#include "MathUtils.h"


float MathUtils::CalculateDistance(
	float2 p1, float2 p2)
{
	float deltaX = fabs(p1.x - p2.x);
	float deltaY = fabs(p1.y - p2.y);

	return sqrt((deltaX * deltaX) + (deltaY * deltaY));
}