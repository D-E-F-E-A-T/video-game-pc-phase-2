#include "pch.h"
#include "EdgeCollisionStrategy.h"
#include "..\Model\Space.h"
#include "..\Model\Stack.h"


void EdgeCollisionStrategy::Detect(
	Player * player,
	list<Space *> * spaces,
	vector<Space *> * retVal,
	vector<float> * distances)
{
	std::list<Space *>::const_iterator iterator;

	for (iterator = spaces->begin(); iterator != spaces->end(); iterator++)
	{
		float fDistance;

		if (IsClose(player, *(iterator), &fDistance))
		{
			retVal->push_back(*(iterator));
			distances->push_back(fDistance);
		}
	}
}

bool EdgeCollisionStrategy::IsClose(
	Player * player,
	Space * obstacle,
	float * pfDistance)
{
	*pfDistance = obstacle->CalculateDistance(player);

	return (*pfDistance < 0.075f);
}