#pragma once
#include "Space.h"

using namespace Platform;

class Movable : public Space
{
public:
	Movable(
		String ^ strTextureName,
		float2 pfLocationRatio,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources)
		: Space(
			strTextureName,
			pfLocationRatio,
			pfDimensions,
			true,
			false,
			true,
			deviceResources)
	{

	}

protected:

private:

};