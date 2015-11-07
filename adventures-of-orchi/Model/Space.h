#pragma once
#include "pch.h"
#include "..\Constants.h"
#include "..\Common\DeviceResources.h"

using namespace BasicSprites;
using namespace std;
using namespace Platform;


class Space
{
public:
	Space() {};

	Space(
		String ^ strTextureName,
		float2 fLocationRatio,
		float2 fDimensions,
		bool bIsVisible,
		bool bIsActionable,
		bool bIsCollidable,
		const shared_ptr<DeviceResources>& deviceResources);

	void Render(
		ComPtr<ID3D11RenderTargetView> renderTargetView,
		float2 fWindowDimensions,
		float2 fScaleDimensions, float dpi);

	float2 GetLocationRatio();

	float2 GetSpriteSize();

	virtual float CalculateDistance(Space * space);

protected:
	float2 m_fLocationRatio;
	float2 m_fDimensions;
	bool m_bIsVisible;
	bool m_bIsActionable;
	bool m_bIsCollidable;

	SpriteBatch ^ m_spriteBatch;

	ID3D11Texture2D * m_pSprite;

	ComPtr<ID3D11Texture2D> m_pTexture;
	
private:
	shared_ptr<DeviceResources> m_deviceResources;
};