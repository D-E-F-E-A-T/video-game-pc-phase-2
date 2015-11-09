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

	Stack * LoadScreen(int x, int y);
	void GetDimensions(int * x, int * y);

protected:
	int m_lpnWorldDimensions[2];

private:
	//vector<Stack *> m_stacks;
	Stack * m_pStack;

};
