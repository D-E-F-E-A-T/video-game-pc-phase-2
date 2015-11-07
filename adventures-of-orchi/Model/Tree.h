#pragma once
#include "Thing.h"

class Tree : public Thing
{
public:
	Tree(
		float2 pfLocationRatio,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources) :
		Thing(
			"tree.dds",
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