#pragma once
#include "..\Grid.h"
#include "..\Constants.h"
#include "Character.h"

class Player : public Character
{
public:
	Player(
		float2 pfLocationRatio,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources)
		: Character(
			"link.dds",
			pfLocationRatio,
			pfDimensions,
			true,
			deviceResources)
	{
		m_nPreviousMoveDirection = CENTER;
	}

	void MoveNorth(int nCollisionState, float fVelocity);
	void MoveEast(int nCollisionState, float fVelocity);
	void MoveSouth(int nCollisionState, float fVelocity);
	void MoveWest(int nCollisionState, float fVelocity);

	// The distance between the Player and itself is 0.
	// The case would be different if there were other Players.
	virtual float CalculateDistance(Space * space) { return 10000000.f; }

protected:

private:
	int m_pGridLocation[NUM_DIMENSIONS];
	int m_nUnitsPerGridSquare[NUM_DIMENSIONS];


	int m_nPreviousMoveDirection;
};