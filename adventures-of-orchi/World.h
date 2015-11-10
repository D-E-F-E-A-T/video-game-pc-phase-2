#pragma once
#include "pch.h"
#include "..\Model\Stack.h"
using namespace std;

class World
{
public:
	World();
	~World();

	void Build(
		float2 fScreenDimensions, 
		const shared_ptr<DeviceResources>& deviceResources);

	void SetScreen(int x, int y);
	Stack * LoadScreen(int x, int y);
	Stack * Move(int nDirection);

protected:
	int m_lpnWorldDimensions[2];

private:
	Stack * m_lpStacks;
	int m_lpnDimensions[2];
	int m_nCurrentStackIndex;


};
