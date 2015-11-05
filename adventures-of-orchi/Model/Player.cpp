#include "pch.h"
#include "Player.h"
#include "Constants.h"

Player::Player(Grid * grid)
{
	m_grid = grid;
	m_fLocationRatio = { 0.5f, 0.5f };
	//m_pfLocationRatio[HORIZONTAL_AXIS] = 0.5f;
	//m_pfLocationRatio[VERTICAL_AXIS] = 0.5f;
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
			m_fLocationRatio.y -= fVelocity;

		// Don't go above the top of the screen. 
		//	Later this will be the trigger to move to the next screen.
		if (prospectiveVerticalRatio >= 0.f)
			m_fLocationRatio.y = prospectiveVerticalRatio;
		else
			m_fLocationRatio.y = 0.0f;

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
			m_fLocationRatio.x += fVelocity;

		if (prospectiveHorizontalRatio <= 1.0f)
		{
			m_fLocationRatio.x = prospectiveHorizontalRatio;
		}
		else
		{
			m_fLocationRatio.x = 1.0f;
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
			m_fLocationRatio.y += fVelocity;

		// Don't go above the top of the screen. 
		//	Later this will be the trigger to move to the next screen.
		if (prospectiveVerticalOffset <= 1.0f)
			m_fLocationRatio.y = prospectiveVerticalOffset;
		else
			m_fLocationRatio.y = 1.0f;

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
			m_fLocationRatio.x -= fVelocity;

		if (prospectiveHorizontalOffset >= 0.f)
		{
			m_fLocationRatio.x = prospectiveHorizontalOffset;
		}
		else
		{
			m_fLocationRatio.x = 0.f;
		}

		UpdateGridLocation();


	}

	m_nPreviousMoveDirection = WEST;
}

void Player::UpdateGridLocation()
{
	int nHorizontalLocation = 
		(int)(m_fLocationRatio.x * TOTAL_GRID_DIVISIONS) /
		m_nUnitsPerGridSquare[HORIZONTAL_AXIS];

	int nVerticalLocation = 
		(int)(m_fLocationRatio.y * TOTAL_GRID_DIVISIONS) /
		m_nUnitsPerGridSquare[VERTICAL_AXIS];

	m_pGridLocation[HORIZONTAL_AXIS] = nHorizontalLocation;
	m_pGridLocation[VERTICAL_AXIS] = nVerticalLocation;
}

