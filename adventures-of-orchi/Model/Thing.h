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
		const shared_ptr<DeviceResources>& deviceResources)
		: Immovable(
			pfLocationRatio,
			pfDimensions,
			bIsVisible,
			bIsActionable,
			bIsCollidable,
			deviceResources)
	{

	}

protected:

private:
};