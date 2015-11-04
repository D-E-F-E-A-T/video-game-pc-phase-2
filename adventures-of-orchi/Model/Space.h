#pragma once
#include "..\BaseSpriteData.h"
#include "..\Constants.h"


class Space
{
public:
	Space() {};

	Space(BaseSpriteData * spriteData)
	{
		this->m_pSprite = spriteData;
	}

	float GetHLocationRatio() { return m_pfLocationRatio[HORIZONTAL_AXIS]; }
	float GetVLocationRatio() { return m_pfLocationRatio[VERTICAL_AXIS]; }

	BaseSpriteData * GetSpriteData() { return m_pSprite; }

protected:


	float m_pfLocationRatio[2];
	float m_pfDimensions[2];
	bool m_bIsVisible;
	bool m_bIsActionable;
	bool m_bIsCollidable;

//	SpaceInfo * m_pInfo;
	BaseSpriteData * m_pSprite;


	// Sprite
	// Action
	
private:
};