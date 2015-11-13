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

	~Space();

	virtual void Render2D(float2 fWindowDimensions) {}

	virtual void Render3D(
		ComPtr<ID3D11RenderTargetView> renderTargetView,
		float2 fWindowDimensions,
		float2 fScaleDimensions, float dpi);

	virtual float2 GetLocationRatio(); // virtual because of Sword.

	float2 GetSpriteSize();

	virtual float CalculateDistance(Space * space);

	ID3D11Texture2D * GetTexture() { return m_pTexture.Get(); }

	uint8_t * GetPixels() { return m_pixelMap[m_pTexture.Get()]; }

	int * GetTextureDimensions() { return m_pTextureDimensions;  }

	vector<Space *> DetectCollisions() {}

protected:
	float2 m_fLocationRatio;
	float2 m_fDimensions;
	bool m_bIsVisible;
	bool m_bIsActionable;
	bool m_bIsCollidable;

	SpriteBatch ^ m_spriteBatch;

	ID3D11Texture2D * m_pSprite;

	ComPtr<ID3D11Texture2D> m_pTexture;

	uint8_t * m_pPixels;
	int m_pTextureDimensions[2];

	static map<ID3D11Texture2D *, uint8_t *> m_pixelMap;

	shared_ptr<DeviceResources> m_deviceResources;

private:

};