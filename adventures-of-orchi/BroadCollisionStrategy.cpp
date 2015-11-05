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
	Grid grid,
	list<Space *> * retVal,
	float2 playerSize,
	float2 spriteSize,
	Player * pPlayer,
	vector<Space *> * sprites,
	float fWindowWidth,
	float fWindowHeight,
	float * playerLocation)
{
	// Determine the 9 grid spaces around the player's location.
	Calculate(
		grid,
		pPlayer, 
		sprites, 
		retVal,
		fWindowWidth,
		fWindowHeight,
		playerLocation);
}

int BroadCollisionStrategy::Calculate(
	Grid grid,
	Player * player, 
	vector<Space *> * sprites, 
	list<Space *> * retVal,
	float fWindowWidth,
	float fWindowHeight,
	float * playerLocation)
{

	int column = 0; 
	int row = 0; 
	
	::ConvertRatioToGridLocations(grid, player->GetLocationRatio(), &column, &row);
/*
	char buf[32];
	sprintf_s(buf, "%d %d\n", nCurrentHorizontalSpace, nCurrentVerticalSpace);
	OutputDebugStringA(buf);
*/


	// Don't use grid spaces as locations since sprites might not be
	//	aligned within a grid space (i.e. moving sprites)

	std::vector<Space *>::const_iterator iterator;

	for (iterator = sprites->begin(); iterator != sprites->end(); iterator++)
	{
//		BaseSpriteData * sprite = (*iterator)->GetSpriteData();

		if (IsClose(player, *(iterator), fWindowWidth, fWindowHeight, playerLocation))
		{
			retVal->push_back(*(iterator));
		}
	}

	return 1;
}

boolean BroadCollisionStrategy::IsClose(
	Player * player, 
	Space * data, 
	float fWindowWidth,
	float fWindowHeight,
	float * playerLocation)
{
	float distance = CalculateDistance(
		*player, 
		data, 
		fWindowWidth, 
		fWindowHeight,
		playerLocation);
	
	return (distance < (fWindowWidth * 0.05f));		
}

float BroadCollisionStrategy::CalculateDistance(
	Player player, 
	Space * sprite,
	float fWindowWidth,
	float fWindowHeight,
	float * playerLocation)
{
	float spriteLocation[2];

	// These are within the range of screen pixel size.
	spriteLocation[0] = sprite->GetLocationRatio().x * fWindowWidth;
	spriteLocation[1] = sprite->GetLocationRatio().y * fWindowHeight;

	float retVal = MathUtils::CalculateDistance(
		playerLocation[0],
		playerLocation[1],
		spriteLocation[0],
		spriteLocation[1]);

	return retVal;
}

