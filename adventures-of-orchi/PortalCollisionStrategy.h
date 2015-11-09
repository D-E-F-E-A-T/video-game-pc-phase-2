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
		list<Space *> * spaces, 
		vector<Space *> * retVal,
		vector<float> * distances);

protected:

	bool IsClose(Player * player, Space * obstacle, float * pfDistance);

private:
};
