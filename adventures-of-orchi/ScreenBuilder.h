#pragma once
#include "pch.h"
#include <vector>
#include "Model\Portal.h"
#include "Model\Space.h"
#include "Model\Stack.h"

using namespace std;

class ScreenBuilder
{
public:
	ScreenBuilder(float screenWidth, float screenHeight);

	// TODO: This will just have 1 argument.
	void BuildScreen1(
		Stack * stack,
		const shared_ptr<DeviceResources>& deviceResources);

protected:

private:
	float m_fScreenWidth;
	float m_fScreenHeight;

};