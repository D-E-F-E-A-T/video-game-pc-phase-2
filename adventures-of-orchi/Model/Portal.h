#pragma once
#include "Stationary.h"

class Portal : public Stationary
{
public:
	Portal(float2 pfLocationRatio, float2 pfDimensions, int nDirection, int nDestination) :
		Stationary(pfLocationRatio, pfDimensions, false, true, true, NULL)
	{
	}

protected:

private:

	int m_nDirection;
	int m_nDestination;

};