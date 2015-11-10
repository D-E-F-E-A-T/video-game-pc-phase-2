#include "pch.h"
#include "Portal.h"

void Portal::Render2D(float2 fWindowDimensions)
{
	float2 fScreenLocation = m_fLocationRatio * fWindowDimensions;

	D2D1_RECT_F rect
	{
		fScreenLocation.x - (fWindowDimensions.x / 100.f),
		fScreenLocation.y - (fWindowDimensions.y / 100.f),
		fScreenLocation.x + (fWindowDimensions.x / 100.f),
		fScreenLocation.y + (fWindowDimensions.y / 100.f)
	};

	DEVICE_CONTEXT_2D->FillRectangle(
		rect,
		m_deviceResources->m_greenBrush.Get());
}

void Portal::Render3D(
	ComPtr<ID3D11RenderTargetView> renderTargetView,
	float2 fWindowDimensions,
	float2 fScaleDimensions, float dpi)
{

}