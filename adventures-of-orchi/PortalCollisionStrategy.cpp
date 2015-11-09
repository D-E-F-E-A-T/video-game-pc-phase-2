#include "pch.h"
#include "PortalCollisionStrategy.h"
#include "..\Model\Space.h"
#include "..\Model\Stack.h"

void PortalCollisionStrategy::Detect(
	Player * pPlayer, 
	Stack * stack,
	list<Space *> * retVal,
	vector<float> * distances)
{
	Calculate(
		pPlayer,
		stack,
		retVal,
		distances);
}

int PortalCollisionStrategy::Calculate(
	Player * player,
	Stack * stack,
	list<Space *> * retVal,
	vector<float> * distances)
{
	int numLayers = stack->GetNumLayers();

	for (int i = 0; i < numLayers; i++)
	{
		std::vector<Space *>::const_iterator iterator;

		for (iterator = stack->Get(i)->GetSpaces()->begin();
		iterator != stack->Get(i)->GetSpaces()->end();
			iterator++)
		{
			float fDistance;

			if (IsClose(player, *(iterator), &fDistance))
			{
				retVal->push_back(*(iterator));
				distances->push_back(fDistance);
			}
		}
	}

	return 1;
}

bool PortalCollisionStrategy::IsClose(
	Player * player,
	Space * obstacle,
	float * pfDistance)
{
	*pfDistance = obstacle->CalculateDistance(player);

	return (*pfDistance < 0.05f);
}