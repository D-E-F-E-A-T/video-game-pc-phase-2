#pragma once
#include "pch.h"
#include "..\Model\Space.h"
#include "..\Model\Player.h"
#include "..\Model\Stack.h"

class PortalCollisionStrategy
{
public:
	void Detect(
		Player * pPlayer, 
		Stack * stack, 
		list<Space *> * retVal,
		vector<float> * distances);

protected:
	int Calculate(
		Player * player, 
		Stack * stack, 
		list<Space *> * retVal, 
		vector<float> * distances);

	bool IsClose(Player * player, Space * obstacle, float * pfDistance);

private:
};
