#pragma once
#include "..\Grid.h"
#include "..\Constants.h"
#include "Space.h"

class Player : public Space
{
public:
	Player();

	void MoveNorth(int nCollisionState, float fVelocity);
	void MoveEast(int nCollisionState, float fVelocity);
	void MoveSouth(int nCollisionState, float fVelocity);
	void MoveWest(int nCollisionState, float fVelocity);

	// Grid square where the player is currently located.
	//int * GetGridLocation()
	//{
	//	return m_pGridLocation;
	//}

protected:
	//void UpdateGridLocation();

private:

	int m_pGridLocation[NUM_DIMENSIONS];

	int m_nUnitsPerGridSquare[NUM_DIMENSIONS];

	//Grid * m_grid;

	int m_nPreviousMoveDirection;
};