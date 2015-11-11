#pragma once
#include "Thing.h"

class Rock: public Thing
{
public:
	Rock(
		float2 pfLocationRatio,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources) :
		Thing(
			"rock.dds",
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