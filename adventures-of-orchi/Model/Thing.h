#pragma once
#include "Immovable.h"

class Thing : public Immovable
{
public:
	Thing(
		float2 pfLocationRatio,
		float2 pfDimensions,
		bool bIsVisible,
		bool bIsActionable,
		bool bIsCollidable,
		ID3D11Texture2D * spriteData)
		: Immovable(
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