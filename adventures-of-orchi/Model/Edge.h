#pragma once
#include "pch.h"
#include "Portal.h"
#include "Constants.h"

class Edge : public Portal
{
public:
	Edge(
		float2 pfLocationRatio,
		float2 pfDimensionRatio,
		int nDirection,
		int nDestination,
		const shared_ptr<DeviceResources>& deviceResources) :
		Portal(
			"stairs.dds",
			pfLocationRatio,
			pfDimensionRatio,
			nDestination,
			deviceResources)
	{
		m_nDirection = nDirection;
	}

	void Render2D(float2 fWindowDimensions);

	virtual void Render3D(
		ComPtr<ID3D11RenderTargetView> renderTargetView,
		float2 fWindowDimensions,
		float2 fScaleDimensions, float dpi);

	int GetDirection() { return m_nDirection; }

protected:

private:
	int m_nDirection;

};