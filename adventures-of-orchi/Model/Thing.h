#pragma once
#include "Immovable.h"

using namespace Platform;

class Thing : public Immovable
{
public:
	Thing(
		String ^ strTextureName,
		float2 pfLocationRatio,
		float2 pfDimensions,
		bool bIsVisible,
		bool bIsActionable,
		bool bIsCollidable,
		const shared_ptr<DeviceResources>& deviceResources)
		: Immovable(
			strTextureName,
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