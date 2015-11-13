#pragma once
#include "Thing.h"

class Grass : public Thing
{
public:
	Grass(
		float2 pfLocationRatio,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources) :
		Thing(
			"grass.dds",
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
