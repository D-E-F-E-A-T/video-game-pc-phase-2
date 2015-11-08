#pragma once
#include "pch.h"
#include "CollisionDetectionStrategy.h"
#include "Model\Player.h"
#include "Model\Space.h"
#include "Model\Stack.h"

class BroadCollisionStrategy // : public CollisionDetectionStrategy
{
public:
	BroadCollisionStrategy();
	bool Detect(CollisionDetectionInfo * info);
	void Detect(Player * pPlayer, Stack * stack, list<Space *> * space);

protected:
	int Calculate(Player * player, Stack * stack, list<Space *> * retVal);

	bool IsClose(Player * player, Space * data);

private:
};