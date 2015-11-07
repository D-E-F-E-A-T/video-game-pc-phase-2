#pragma once
#include "pch.h"
#include "CollisionDetectionStrategy.h"
#include "Model\Player.h"
#include "Model\Space.h"

class BroadCollisionStrategy // : public CollisionDetectionStrategy
{
public:
	BroadCollisionStrategy();
	bool Detect(CollisionDetectionInfo * info);

	void Detect(
		Player * pPlayer,
		vector<Space *> * sprites,
		list<Space *> * space);

protected:
	int Calculate(
		Player * player, 
		vector<Space *> * spaces, 
		list<Space *> * retVal);

	bool IsClose(
		Player * player,
		Space * data);

private:
};