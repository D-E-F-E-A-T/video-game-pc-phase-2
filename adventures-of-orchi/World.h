#pragma once
#include "pch.h"
#include "..\Model\Stack.h"
#include "ScreenBuilder.h"
using namespace std;

class World
{
public:
	World();
	~World();

	void Build();
	Stack * LoadScreen(int x, int y);
	void GetDimensions(int * x, int * y);

protected:
	int m_lpnWorldDimensions[2];

private:
	vector<Stack *> m_stacks;
	ScreenBuilder * m_pScreenBuilder;

};
