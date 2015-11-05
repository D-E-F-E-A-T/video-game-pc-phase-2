#pragma once
#include "Stationary.h"

class Thing : public Stationary
{
public:
	Thing(
		float2 pfLocationRatio,
		float2 pfDimensions,
		bool bIsVisible,
		bool bIsActionable,
		bool bIsCollidable,
		ID3D11Texture2D * spriteData)
		: Stationary(
			pfLocationRatio,
			pfDimensions,
			bIsVisible,
			bIsActionable,
			bIsCollidable,
			spriteData)
	{

	}

protected:

private:
};