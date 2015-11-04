#pragma once
#include "pch.h"
#include "CollisionDetectionStrategy.h"
#include "Model\Player.h"
#include "BaseSpriteData.h"
#include "GridSpace.h"
#include "Model\Space.h"

class BroadCollisionStrategy // : public CollisionDetectionStrategy
{
public:
	BroadCollisionStrategy();
	bool Detect(CollisionDetectionInfo * info);

	void Detect(
		list<BaseSpriteData *> * retVal,
		float2 playerSize,
		float2 spriteSize,
		Player * pPlayer,
		vector<Space *> * sprites,
		float fWindowWidth,
		float fWindowHeight,
		float * playerLocation);

protected:
	int Calculate(
		Player * player, 
		vector<Space *> * sprites, 
		list<BaseSpriteData *> * retVal,
		float fWindowWidth,
		float fWindowHeight,
		float * playerLocation);

	boolean IsClose(
		Player * player, 
		BaseSpriteData * data,
		float fWindowWidth,
		float fWindowHeight,
		float * playerLocation);

	float CalculateDistance(
		Player player, 
		BaseSpriteData * sprite,
		float fWindowWidth, 
		float fWindowHeight,
		float * playerLocation);

private:
};