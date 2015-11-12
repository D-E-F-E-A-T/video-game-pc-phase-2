#pragma once
#include "pch.h"
#include "Portal.h"
#include "Constants.h"

class Stairs : public Portal
{
public:
	Stairs(
		float2 pfLocationRatio,
		float2 pfDimensionRatio,
		int nDestination,
		const shared_ptr<DeviceResources>& deviceResources) :
		Portal(
			"stairs.dds",
			pfLocationRatio,
			pfDimensionRatio,
			NO_DIRECTION,
			nDestination,
			deviceResources)
	{
	}

	void Render2D(float2 fWindowDimensions) {}

	void Render3D(
		ComPtr<ID3D11RenderTargetView> renderTargetView,
		float2 fWindowDimensions,
		float2 fScaleDimensions, float dpi)
	{
//		Immovable::
	}

protected:

private:

};