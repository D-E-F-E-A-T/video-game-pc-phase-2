#pragma once
#include "Space.h"


class Immovable : public Space
{
public:
	Immovable(
		float2 pfLocationRatio,
		float2 pfDimensions,
		bool bIsVisible,
		bool bIsActionable,
		bool bIsCollidable,
		ID3D11Texture2D * spriteData)
		: Space(
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