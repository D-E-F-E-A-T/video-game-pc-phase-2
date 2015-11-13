#pragma once
#include "Tool.h"

class Sword : public Tool
{
public:
	Sword(
		float2 pfLocationRatio,
		const shared_ptr<DeviceResources>& deviceResources) :
		Tool(
			"sword-left.dds",	// Make this an array.
			pfLocationRatio,
			float2{ 1.f, 1.f },
			true,
			deviceResources)
	{

	}

	float2 GetLocationRatio()
	{
		m_fLocationRatio = m_fLocationRatio - float2{ 0.03f, 0.f };
		return m_fLocationRatio;
	}

protected:

private:
};