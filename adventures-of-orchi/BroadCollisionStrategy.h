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
		Grid grid,
		list<Space *> * retVal,
		float2 playerSize,
		float2 spriteSize,
		Player * pPlayer,
		vector<Space *> * sprites,
		float fWindowWidth,
		float fWindowHeight,
		float * playerLocation);

protected:
	int Calculate(
		Grid grid,
		Player * player, 
		vector<Space *> * sprites, 
		list<Space *> * retVal,
		float fWindowWidth,
		float fWindowHeight,
		float * playerLocation);

	boolean IsClose(
		Player * player, 
		Space * data,
		float fWindowWidth,
		float fWindowHeight,
		float * playerLocation);

	float CalculateDistance(
		Player player, 
		Space * sprite,
		float fWindowWidth, 
		float fWindowHeight,
		float * playerLocation);

private:
};