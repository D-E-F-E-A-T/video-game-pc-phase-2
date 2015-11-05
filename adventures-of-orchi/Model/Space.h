#pragma once
#include "..\pch.h"
#include "..\Constants.h"


class Space
{
public:
	Space() {};

	Space(
		float2 fLocationRatio,
		float2 fDimensions,

		bool bIsVisible,
		bool bIsActionable,
		bool bIsCollidable,
		ID3D11Texture2D * spriteData)
	{
		m_pSprite = spriteData;
		m_fLocationRatio = fLocationRatio;
		m_fDimensions = fDimensions;

		m_bIsVisible = bIsVisible;
		m_bIsActionable = bIsActionable;
		m_bIsCollidable = bIsCollidable;
	}

	float2 GetLocationRatio() { return m_fLocationRatio; }
	ID3D11Texture2D * GetSpriteTexture() { return m_pSprite; }

protected:
	float2 m_fLocationRatio;
	float2 m_fDimensions;
	bool m_bIsVisible;
	bool m_bIsActionable;
	bool m_bIsCollidable;

//	SpaceInfo * m_pInfo;
	ID3D11Texture2D * m_pSprite;
	
private:
};