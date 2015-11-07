#include "pch.h"
#include "BroadCollisionStrategy.h"
#include <vector>
#include "Model\Player.h"
#include "MathUtils.h"
#include <iostream>
#include "Utils.h"

// @see http://www.gamedev.net/page/resources/_/technical/directx-and-xna/pixel-perfect-collision-detection-in-directx-r2939
BroadCollisionStrategy::BroadCollisionStrategy()
{

}

bool BroadCollisionStrategy::Detect(CollisionDetectionInfo * info)
{
	return false;
}

void BroadCollisionStrategy::Detect(
	Player * pPlayer,
	vector<Space *> * spaces,
	list<Space *> * retVal)
{
	// Determine the 9 grid spaces around the player's location.
	Calculate(
		pPlayer, 
		spaces, 
		retVal);
}

int BroadCollisionStrategy::Calculate(
	Player * player, 
	vector<Space *> * spaces, 
	list<Space *> * retVal)
{
	std::vector<Space *>::const_iterator iterator;

	for (iterator = spaces->begin(); iterator != spaces->end(); iterator++)
	{
		if (IsClose(player, *(iterator)))
		{
			retVal->push_back(*(iterator));
		}
	}

	return 1;
}

bool BroadCollisionStrategy::IsClose(
	Player * player, 
	Space * obstacle)
{
	float distance = obstacle->CalculateDistance(player);
	
	return (distance < 0.075f);		
}

