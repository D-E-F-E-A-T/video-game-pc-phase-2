#include "pch.h"
#include "Edge.h"

void Edge::Render2D(float2 fWindowDimensions)
{
#ifdef RENDER_DIAGNOSTICS
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
		m_deviceResources->m_blackBrush.Get());
#endif // RENDER_DIAGNOSTICS
}

void Edge::Render3D(
	ComPtr<ID3D11RenderTargetView> renderTargetView,
	float2 fWindowDimensions,
	float2 fScaleDimensions, float dpi)
{
	// No-op.
}
