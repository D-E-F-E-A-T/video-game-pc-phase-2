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

	// TODO: Don't do this.
	int GetType() { return 1; }

protected:

private:
	int m_pGridLocation[NUM_DIMENSIONS];
	int m_nUnitsPerGridSquare[NUM_DIMENSIONS];


	int m_nPreviousMoveDirection;
};