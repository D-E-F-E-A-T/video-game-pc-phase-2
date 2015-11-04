#include "pch.h"
#include "Player.h"
#include "Constants.h"

Player::Player(Grid * grid)
{
	m_grid = grid;
	m_pfLocationRatio[HORIZONTAL_AXIS] = 0.5f;
	m_pfLocationRatio[VERTICAL_AXIS] = 0.5f;
	m_nPreviousMoveDirection = CENTER;

	m_nUnitsPerGridSquare[HORIZONTAL_AXIS] =
		(int)(1.0f / (float)grid->GetNumColumns() * (float)TOTAL_GRID_DIVISIONS);

	m_nUnitsPerGridSquare[VERTICAL_AXIS] =
		(int)(1.0f / (float)grid->GetNumRows() * (float)TOTAL_GRID_DIVISIONS);

	UpdateGridLocation();
}

void Player::MoveNorth(int nCollisionState, float fVelocity)
{
	if (nCollisionState == COLLISION && m_nPreviousMoveDirection == NORTH)
	{
	}
	else
	{
		float prospectiveVerticalRatio =
			m_pfLocationRatio[VERTICAL_AXIS] -= fVelocity;

		// Don't go above the top of the screen. 
		//	Later this will be the trigger to move to the next screen.
		if (prospectiveVerticalRatio >= 0.f)
			m_pfLocationRatio[VERTICAL_AXIS] = prospectiveVerticalRatio;
		else
			m_pfLocationRatio[VERTICAL_AXIS] = 0.0f;

		UpdateGridLocation();


	}

	m_nPreviousMoveDirection = NORTH;
}

void Player::MoveEast(int nCollisionState, float fVelocity)
{
	if (nCollisionState == COLLISION && m_nPreviousMoveDirection == EAST)
	{
	}
	else
	{
		float prospectiveHorizontalRatio =
			m_pfLocationRatio[HORIZONTAL_AXIS] += fVelocity;

		if (prospectiveHorizontalRatio <= 1.0f)
		{
			m_pfLocationRatio[HORIZONTAL_AXIS] = prospectiveHorizontalRatio;
		}
		else
		{
			m_pfLocationRatio[HORIZONTAL_AXIS] = 1.0f;
		}

		UpdateGridLocation();


	}

	m_nPreviousMoveDirection = EAST;
}

void Player::MoveSouth(int nCollisionState, float fVelocity)
{
	if (nCollisionState == COLLISION && m_nPreviousMoveDirection == SOUTH)
	{
	}
	else
	{
		float prospectiveVerticalOffset =
			m_pfLocationRatio[VERTICAL_AXIS] += fVelocity;

		// Don't go above the top of the screen. 
		//	Later this will be the trigger to move to the next screen.
		if (prospectiveVerticalOffset <= 1.0f)
			m_pfLocationRatio[VERTICAL_AXIS] = prospectiveVerticalOffset;
		else
			m_pfLocationRatio[VERTICAL_AXIS] = 1.0f;

		UpdateGridLocation();


	}

	m_nPreviousMoveDirection = SOUTH;
}

void Player::MoveWest(int nCollisionState, float fVelocity)
{
	if (nCollisionState == COLLISION && m_nPreviousMoveDirection == WEST)
	{
	}
	else
	{
		float prospectiveHorizontalOffset =
			m_pfLocationRatio[HORIZONTAL_AXIS] -= fVelocity;

		if (prospectiveHorizontalOffset >= 0.f)
		{
			m_pfLocationRatio[HORIZONTAL_AXIS] = prospectiveHorizontalOffset;
		}
		else
		{
			m_pfLocationRatio[HORIZONTAL_AXIS] = 0.f;
		}

		UpdateGridLocation();


	}

	m_nPreviousMoveDirection = WEST;
}

void Player::UpdateGridLocation()
{
	int nHorizontalLocation = 
		(int)(m_pfLocationRatio[HORIZONTAL_AXIS] * TOTAL_GRID_DIVISIONS) /
		m_nUnitsPerGridSquare[HORIZONTAL_AXIS];

	int nVerticalLocation = 
		(int)(m_pfLocationRatio[VERTICAL_AXIS] * TOTAL_GRID_DIVISIONS) /
		m_nUnitsPerGridSquare[VERTICAL_AXIS];

	m_pGridLocation[HORIZONTAL_AXIS] = nHorizontalLocation;
	m_pGridLocation[VERTICAL_AXIS] = nVerticalLocation;
}

