#pragma once
#include "pch.h"
#include "TreeData.h"
#include <vector>
#include "Portal.h"

using namespace std;

class ScreenBuilder
{
public:
	ScreenBuilder(float screenWidth, float screenHeight);
	void BuildScreen1(vector<BaseSpriteData *> * m_treeData, vector<Portal *> * m_portals);

protected:

private:
	float m_fScreenWidth;
	float m_fScreenHeight;

};