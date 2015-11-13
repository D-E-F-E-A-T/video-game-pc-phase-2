#pragma once
#include "Immovable.h"

class Portal : public Immovable
{
public:
	Portal(
		Platform::String ^ strTextureName,
		float2 pfLocationRatio, 
		float2 pfDimensionRatio, 
		int nDestination,
		const shared_ptr<DeviceResources>& deviceResources) :
		Immovable(
			strTextureName, 
			pfLocationRatio, 
			pfDimensionRatio, 
			false, 
			true, 
			true, 
			deviceResources)
	{
		m_nDestination = nDestination;
	}

	int GetDestination() { return m_nDestination; }

protected:
	int m_nDestination;

private:

};