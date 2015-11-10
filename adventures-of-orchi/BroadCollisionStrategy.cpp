#include "pch.h"
#include "BroadCollisionStrategy.h"
#include <vector>
#include "Model\Player.h"
#include "MathUtils.h"
#include <iostream>
#include "Utils.h"
#include "Model\Stack.h"

// @see http://www.gamedev.net/page/resources/_/technical/directx-and-xna/pixel-perfect-collision-detection-in-directx-r2939
BroadCollisionStrategy::BroadCollisionStrategy()
{

}

void BroadCollisionStrategy::Detect(
	int nLayer,
	Player * pPlayer,
	Stack * stack,
	list<Space *> * retVal)
{
	Calculate(
		nLayer,
		pPlayer, 
		stack, 
		retVal);
}

int BroadCollisionStrategy::Calculate(
	int nLayer, 
	Player * player, 
	Stack * stack,
	list<Space *> * retVal)
{
	int numLayers = stack->GetNumLayers();

	std::vector<Space *>::const_iterator iterator;

	for (iterator = stack->Get(nLayer)->GetSpaces()->begin();
		iterator != stack->Get(nLayer)->GetSpaces()->end();
		iterator++)
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

