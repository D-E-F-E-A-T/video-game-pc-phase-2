#include "pch.h"
#include "Space.h"
#include "..\MathUtils.h"


using namespace std;


Space::Space(
	String ^ strTextureName,
	float2 fLocationRatio,
	float2 fDimensions,
	bool bIsVisible,
	bool bIsActionable,
	bool bIsCollidable,
	const shared_ptr<DeviceResources>& deviceResources)
{
	m_deviceResources = deviceResources;

	m_fLocationRatio = fLocationRatio;
	m_fDimensions = fDimensions;

	m_bIsVisible = bIsVisible;
	m_bIsActionable = bIsActionable;
	m_bIsCollidable = bIsCollidable;

	// Consider that not all spaces are Sprites!!
	if (strTextureName != nullptr)
	{
		m_spriteBatch = ref new BasicSprites::SpriteBatch();

		m_spriteBatch->Initialize(
			m_deviceResources->GetD3DDevice(),
			1);

		BasicLoader ^ loader =
			ref new BasicLoader(
				m_deviceResources->GetD3DDevice(),
				m_deviceResources->GetWicImagingFactory());

		// Use flyweight pattern to avoid loading this for every tree.
		loader->LoadTexture(
			strTextureName,
			&m_pTexture,
			nullptr);

		m_spriteBatch->AddTexture(m_pTexture.Get());
	}
}

void Space::Render(
	ComPtr<ID3D11RenderTargetView> renderTargetView,
	float2 fWindowDimensions,
	float2 fScaleDimensions, float dpi)
{
	m_spriteBatch->Begin(renderTargetView.Get(), dpi);

	float2 fPosition =
		GetLocationRatio() * float2(fWindowDimensions.x, fWindowDimensions.y);

	m_spriteBatch->Draw(
		m_pTexture.Get(),
		fPosition,
		BasicSprites::PositionUnits::DIPs,
		m_fDimensions * fScaleDimensions,
		BasicSprites::SizeUnits::DIPs,
		float4(0.8f, 0.8f, 1.0f, 1.0f),
		0.0f);

	m_spriteBatch->End();
}

float2 Space::GetLocationRatio()
{
	return m_fLocationRatio;
}

float2 Space::GetSpriteSize()
{
	return m_spriteBatch->GetSpriteSize(m_pTexture.Get());
}

float Space::CalculateDistance(Space * space)
{
	return MathUtils::CalculateDistance(
		m_fLocationRatio, 
		space->GetLocationRatio());
}