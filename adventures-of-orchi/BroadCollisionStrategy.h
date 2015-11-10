#pragma once
#include "pch.h"
#include "Model\Player.h"
#include "Model\Space.h"
#include "Model\Stack.h"

class BroadCollisionStrategy
{
public:
	BroadCollisionStrategy();
	void Detect(int nLayer, Player * pPlayer, Stack * stack, list<Space *> * space);

protected:
	int Calculate(int nLayer, Player * player, Stack * stack, list<Space *> * retVal);

	bool IsClose(Player * player, Space * data);

private:
};