#pragma once
#include "Thing.h"

class StoneWall : public Thing
{
public:
	StoneWall(
		float2 pfLocationRatio,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources) :
		Thing(
			"stonewall.dds",
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