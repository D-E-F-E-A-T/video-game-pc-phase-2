#pragma once
#include "pch.h"
#include "Movable.h"

class Tool : public Movable
{
public:
	Tool(
		String ^ strTextureName,
		float2 pfLocationRatio,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources)
		: Movable(
			strTextureName,
			pfLocationRatio,
			pfDimensions,
			bIsVisible,
			deviceResources) {};

protected:

private:
};